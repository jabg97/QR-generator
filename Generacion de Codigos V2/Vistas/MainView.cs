using Generacion_codigos_V2.Controladores;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Generacion_codigos_V2.Vistas
{
    public partial class MainView : MaterialForm
    {
        private QRController controlador = new QRController();
        private ArrayList titulos = new ArrayList();
        private ArrayList lista = new ArrayList();

        public object[] data { set; get; }

        private string tipo_equipo = "";

        public MainView()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.Lime700, Accent.Pink700,
                TextShade.WHITE
            );
 
        }

        private void btn_Buscar_Click(object sender, System.EventArgs e)
        {
            seleccionar_archivo.ShowDialog();
        }


        private void Seleccionar_archivo_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            try
            {
                this.tipo_equipo = txt_tipo_equipo.Text;
                if (string.IsNullOrEmpty(this.tipo_equipo) || string.IsNullOrWhiteSpace(this.tipo_equipo))
                {
                    MessageBox.Show("Escriba el tipo de equipo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string ruta = seleccionar_archivo.FileName;
                    if (string.IsNullOrEmpty(ruta) || string.IsNullOrWhiteSpace(ruta))
                    {
                        MessageBox.Show("Seleccione un archivo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        btn_Exportar.Visible = false;
                        txt_Tamaño.Visible = false;
                        label_txt_Tamaño.Visible = false;
                        this.data = controlador.LeerExcel(ruta);
                        equipos_table.Rows.Clear();
                        equipos_table.Columns.Clear();
                        this.titulos = (ArrayList)this.data[0];
                        this.lista = (ArrayList)this.data[1];

                        if (titulos.Count > 0)
                        {

                            foreach (String titulo in titulos)
                            {
                                equipos_table.Columns.Add(titulo, titulo);
                            }

                            if (lista.Count > 0)
                            {
                                    foreach (String[] row in lista)
                                    {
                                        equipos_table.Rows.Add(row);
                                    }

                                    btn_Exportar.Visible = true;
                                txt_Tamaño.Visible = true;
                                label_txt_Tamaño.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("La lista de equipos esta vacia.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }


                        }
                    
                            else
                    {
                        MessageBox.Show("El archivo esta vacio.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
            private void GenerarZip()
        {
            string stamaño = txt_Tamaño.Text.ToUpper();
            if (String.IsNullOrWhiteSpace(stamaño) || String.IsNullOrEmpty(stamaño))
            {
                MessageBox.Show("Por favor escriba el tamaño del codigo QR.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tamaño = 0;
                if (!Int32.TryParse(stamaño, out tamaño))
                {
                    MessageBox.Show("Solo se permiten numeros.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tamaño < 100 || tamaño > 1000)
                {
                    MessageBox.Show("Solo se permiten codigos entre 100 y 1000 pixeles.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        controlador.exportarZip(titulos,lista, tamaño, tipo_equipo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
            GenerarZip();
        }

        private void txt_Tamaño_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GenerarZip();
            }
        }
    }
}
