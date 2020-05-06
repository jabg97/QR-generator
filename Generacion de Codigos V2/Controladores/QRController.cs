using System;
using ZXing;
using ZXing.QrCode;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Diagnostics;
using ZXing.QrCode.Internal;
using Microsoft.Office.Interop.Excel;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using Ionic.Zip;

namespace Generacion_codigos_V2.Controladores
{
    public class QRController
    {

        public object[] LeerExcel(string ruta)
        {
            Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlsApp == null)
            {
                throw new Exception("Microsoft Excel no se pudo iniciar. Verifique que la instalación de Microsoft Office y las referencias del proyecto sean correctas.");
            }

            //Displays Excel so you can see what is happening
            xlsApp.Visible = false;

            object[] info = new object[4];
     
                Workbook wb = xlsApp.Workbooks.Open(ruta,
               0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true);
                Sheets sheets = wb.Worksheets;
                Worksheet ws = (Worksheet)sheets.get_Item(1);

                Range firstColumn = ws.UsedRange.Columns[1];
                Array myvalues = (Array)firstColumn.Cells.Value;
                string[] strArray = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();
                ArrayList titulos = new ArrayList();
                ArrayList equipos = new ArrayList();
                ArrayList errores = new ArrayList();
                ArrayList msg_errores = new ArrayList();
            int cont = 0;
            if (strArray.Length < 2)
                {
                xlsApp.Quit();
                throw new Exception("El archivo no tiene registros.");
                } else {
                    
 
                    if (!strArray[0].Trim().Equals("Codigo"))
                    {
                    xlsApp.Quit();
                    throw new Exception("La primera columna debe llamarse \"Codigo\".");
                    }
                    else
                    {
                        foreach (Range column in ws.UsedRange.Columns)
                        {
                            ArrayList row = new ArrayList();
                            Array tablevalues = (Array)column.Cells.Value;
                            string[] lista = tablevalues.OfType<object>().Select(o => o.ToString()).ToArray();
                            titulos.Add(lista[0].Trim());
                        

                            for (int i = 1; i < lista.Length; i++)
                            {

                                if (lista[0].Trim().Equals("Codigo"))
                                {
                                row.Add(lista[i].Trim());
                                cont++;
                            }
                                else
                                {
                                    row.Add(lista[i].Trim());
                                }
                        }
                            equipos.Add(row.ToArray());
                        }
                        info[0] = titulos;
                        info[1] = CrearLista(equipos.ToArray(),cont, titulos.Count);
                    }
                }
                
     
                xlsApp.Quit();
  

            return info;
        }

        private ArrayList CrearLista(object[] lista, int fil, int col)
        {

            ArrayList nuevo = new ArrayList();

            for (int f = 0; f < fil; f++)
            {
                string[] row = new string[col]; 
                for (int c = 0; c < col; c++)
              {
                    row[c] = (string)((object[])lista[c])[f];
                }
                nuevo.Add(row);
            }       
            return nuevo;
        }

         public Hashtable configureQR(string info, int tamaño, string tipo_equipo)
         {
             Hashtable table = new Hashtable();

                 DateTime ahora = DateTime.UtcNow.Date;
                 table.Add("DATA", info);
          
             table.Add("CONFIGURATION", new QrCodeEncodingOptions
             {
                 ErrorCorrection = ErrorCorrectionLevel.L,
                 Margin = 1,
                 DisableECI = true,
                 CharacterSet = "UTF-8",
                 Width = tamaño,
                 Height = tamaño,
             });
             return table;
         }

        public void generarQR(Hashtable data, PictureBox qrbox)
        {
            qrbox.Image = generarImagen(data);
        }

        public Bitmap generarImagen(Hashtable data)
        {
            BarcodeWriter qr = new BarcodeWriter();
            qr.Options = (QrCodeEncodingOptions)data["CONFIGURATION"];
            qr.Format = BarcodeFormat.QR_CODE;
            return new Bitmap(qr.Write(Convert.ToString(data["DATA"])));
        }


        public void exportarQR(Hashtable data, int tamaño, string codigo, string tipo_equipo)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.CreatePrompt = true;
            save.OverwritePrompt = true;
            save.FileName = tipo_equipo + " " + codigo + " (" + tamaño + "px)";
            save.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIF|*.gif";
            if (save.ShowDialog() == DialogResult.OK)
            {
                save.InitialDirectory = Environment.GetFolderPath
                            (Environment.SpecialFolder.Desktop);
                generarImagen(data).Save(save.FileName);
                Process.Start(save.FileName);
            }

        }

        public void exportarZip(ArrayList header, ArrayList lista, int tamaño, string tipo_equipo)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string hoy = dateTime.ToString("yyyy-MM-dd");
            DirectoryInfo carpeta = Directory.CreateDirectory("Codigos " + tipo_equipo + " " + hoy + " (" + tamaño + "px)");
           // carpeta.Delete(true);
            object[] titulos = header.ToArray();
            foreach (string[] row in lista)
            {
                string archivo = carpeta.FullName + "/" + row[0] + " (" + tamaño + "px).png";
              //  Console.WriteLine(archivo);

                string info = (string)titulos[0]+": " + row[0];
                for (int i = 1; i < titulos.Length; i++)
                {
                    info += "\n"+ (string)titulos[i] + ": " + row[i];
                }
               // Console.WriteLine(info);
                generarImagen(configureQR(info, tamaño, tipo_equipo)).Save(archivo);
            }
            SaveFileDialog save = new SaveFileDialog();
            save.CreatePrompt = true;
            save.OverwritePrompt = true;
            save.FileName = carpeta.Name;
            save.Filter = "Archivo ZIP|*.zip";
            if (save.ShowDialog() == DialogResult.OK)
            {
                save.InitialDirectory = Environment.GetFolderPath
                            (Environment.SpecialFolder.Desktop);
                string startPath = carpeta.FullName;
                string zipPath = save.FileName;
                using (ZipFile zip = new ZipFile())
                {
                    zip.AddDirectory(startPath);
                    zip.Save(zipPath);
                }
                carpeta.Delete(true);
                Process.Start(save.FileName);
            }


        }


    }
}
