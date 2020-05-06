namespace Generacion_codigos_V2.Vistas
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.txt_Tamaño = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label_txt_Tamaño = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btn_Exportar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_Buscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.seleccionar_archivo = new System.Windows.Forms.OpenFileDialog();
            this.equipos_table = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.divisor_search_Form = new MaterialSkin.Controls.MaterialDivider();
            this.txt_tipo_equipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.equipos_table)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Tamaño
            // 
            this.txt_Tamaño.Depth = 0;
            this.txt_Tamaño.Hint = "";
            this.txt_Tamaño.Location = new System.Drawing.Point(11, 378);
            this.txt_Tamaño.MaxLength = 32767;
            this.txt_Tamaño.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Tamaño.Name = "txt_Tamaño";
            this.txt_Tamaño.PasswordChar = '\0';
            this.txt_Tamaño.SelectedText = "";
            this.txt_Tamaño.SelectionLength = 0;
            this.txt_Tamaño.SelectionStart = 0;
            this.txt_Tamaño.Size = new System.Drawing.Size(166, 23);
            this.txt_Tamaño.TabIndex = 24;
            this.txt_Tamaño.TabStop = false;
            this.txt_Tamaño.Text = "100";
            this.txt_Tamaño.UseSystemPasswordChar = false;
            this.txt_Tamaño.Visible = false;
            this.txt_Tamaño.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tamaño_KeyDown);
            // 
            // label_txt_Tamaño
            // 
            this.label_txt_Tamaño.AutoSize = true;
            this.label_txt_Tamaño.Depth = 0;
            this.label_txt_Tamaño.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_txt_Tamaño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_txt_Tamaño.Location = new System.Drawing.Point(12, 356);
            this.label_txt_Tamaño.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_txt_Tamaño.Name = "label_txt_Tamaño";
            this.label_txt_Tamaño.Size = new System.Drawing.Size(126, 19);
            this.label_txt_Tamaño.TabIndex = 23;
            this.label_txt_Tamaño.Text = "Tamaño (Pixeles)";
            this.label_txt_Tamaño.Visible = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(7, 337);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(720, 10);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.AutoSize = true;
            this.btn_Exportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exportar.Depth = 0;
            this.btn_Exportar.Icon = null;
            this.btn_Exportar.Location = new System.Drawing.Point(632, 365);
            this.btn_Exportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Primary = true;
            this.btn_Exportar.Size = new System.Drawing.Size(90, 36);
            this.btn_Exportar.TabIndex = 21;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Visible = false;
            this.btn_Exportar.Click += new System.EventHandler(this.Btn_Exportar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.AutoSize = true;
            this.btn_Buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.Depth = 0;
            this.btn_Buscar.Icon = null;
            this.btn_Buscar.Location = new System.Drawing.Point(554, 88);
            this.btn_Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Primary = true;
            this.btn_Buscar.Size = new System.Drawing.Size(173, 36);
            this.btn_Buscar.TabIndex = 25;
            this.btn_Buscar.Text = "Seleccionar Archivo";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // seleccionar_archivo
            // 
            this.seleccionar_archivo.Filter = "Archivos de Excel|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt;*.xls;*.xml;*.xm" +
    "l;*.xlam;*.xla;*.xlw;*.xlr;";
            this.seleccionar_archivo.Title = "Seleccione el archivo de excel";
            this.seleccionar_archivo.FileOk += new System.ComponentModel.CancelEventHandler(this.Seleccionar_archivo_FileOk);
            // 
            // equipos_table
            // 
            this.equipos_table.AllowUserToAddRows = false;
            this.equipos_table.AllowUserToDeleteRows = false;
            this.equipos_table.AllowUserToOrderColumns = true;
            this.equipos_table.BackgroundColor = System.Drawing.Color.White;
            this.equipos_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.equipos_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.equipos_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipos_table.Cursor = System.Windows.Forms.Cursors.Default;
            this.equipos_table.Location = new System.Drawing.Point(16, 158);
            this.equipos_table.Name = "equipos_table";
            this.equipos_table.ReadOnly = true;
            this.equipos_table.Size = new System.Drawing.Size(711, 164);
            this.equipos_table.TabIndex = 26;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(310, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 19);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Lista de Equipos";
            // 
            // divisor_search_Form
            // 
            this.divisor_search_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.divisor_search_Form.Depth = 0;
            this.divisor_search_Form.Location = new System.Drawing.Point(12, 130);
            this.divisor_search_Form.MouseState = MaterialSkin.MouseState.HOVER;
            this.divisor_search_Form.Name = "divisor_search_Form";
            this.divisor_search_Form.Size = new System.Drawing.Size(720, 3);
            this.divisor_search_Form.TabIndex = 19;
            // 
            // txt_tipo_equipo
            // 
            this.txt_tipo_equipo.Depth = 0;
            this.txt_tipo_equipo.Hint = "";
            this.txt_tipo_equipo.Location = new System.Drawing.Point(21, 101);
            this.txt_tipo_equipo.MaxLength = 32767;
            this.txt_tipo_equipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tipo_equipo.Name = "txt_tipo_equipo";
            this.txt_tipo_equipo.PasswordChar = '\0';
            this.txt_tipo_equipo.SelectedText = "";
            this.txt_tipo_equipo.SelectionLength = 0;
            this.txt_tipo_equipo.SelectionStart = 0;
            this.txt_tipo_equipo.Size = new System.Drawing.Size(156, 23);
            this.txt_tipo_equipo.TabIndex = 32;
            this.txt_tipo_equipo.TabStop = false;
            this.txt_tipo_equipo.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 31;
            this.materialLabel3.Text = "Tipo Equipo";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 405);
            this.Controls.Add(this.txt_tipo_equipo);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.equipos_table);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Tamaño);
            this.Controls.Add(this.label_txt_Tamaño);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.divisor_search_Form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Principal";
            ((System.ComponentModel.ISupportInitialize)(this.equipos_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Tamaño;
        private MaterialSkin.Controls.MaterialLabel label_txt_Tamaño;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Exportar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_Buscar;
        private System.Windows.Forms.OpenFileDialog seleccionar_archivo;
        private System.Windows.Forms.DataGridView equipos_table;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider divisor_search_Form;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tipo_equipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}