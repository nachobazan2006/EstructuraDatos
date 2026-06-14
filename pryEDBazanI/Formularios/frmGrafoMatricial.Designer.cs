namespace pryEDBazanI.Formularios
{
    partial class frmGrafoMatricial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picGrafo = new System.Windows.Forms.PictureBox();
            this.grpCargaDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtPrecioCarga = new System.Windows.Forms.TextBox();
            this.lblPrecioCarga = new System.Windows.Forms.Label();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.lblDestinoCarga = new System.Windows.Forms.Label();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.lblOrigenCarga = new System.Windows.Forms.Label();
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.btnBorrarConsulta = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPrecioConsulta = new System.Windows.Forms.TextBox();
            this.lblPrecioConsulta = new System.Windows.Forms.Label();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.lblDestinoConsulta = new System.Windows.Forms.Label();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.lblOrigenConsulta = new System.Windows.Forms.Label();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).BeginInit();
            this.grpCargaDatos.SuspendLayout();
            this.grpConsultaDatos.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // picGrafo
            // 
            this.picGrafo.BackColor = System.Drawing.Color.White;
            this.picGrafo.Image = global::pryEDBazanI.Properties.Resources.grafo_matricial;
            this.picGrafo.Location = new System.Drawing.Point(15, 58);
            this.picGrafo.Name = "picGrafo";
            this.picGrafo.Size = new System.Drawing.Size(224, 151);
            this.picGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGrafo.TabIndex = 0;
            this.picGrafo.TabStop = false;
            // 
            // grpCargaDatos
            // 
            this.grpCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.grpCargaDatos.Controls.Add(this.btnCargar);
            this.grpCargaDatos.Controls.Add(this.txtPrecioCarga);
            this.grpCargaDatos.Controls.Add(this.lblPrecioCarga);
            this.grpCargaDatos.Controls.Add(this.cmbDestinoCarga);
            this.grpCargaDatos.Controls.Add(this.lblDestinoCarga);
            this.grpCargaDatos.Controls.Add(this.cmbOrigenCarga);
            this.grpCargaDatos.Controls.Add(this.lblOrigenCarga);
            this.grpCargaDatos.Location = new System.Drawing.Point(251, 52);
            this.grpCargaDatos.Name = "grpCargaDatos";
            this.grpCargaDatos.Size = new System.Drawing.Size(244, 162);
            this.grpCargaDatos.TabIndex = 1;
            this.grpCargaDatos.TabStop = false;
            this.grpCargaDatos.Text = "Carga de Datos:";
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(16, 108);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(103, 31);
            this.btnBorrarTodo.TabIndex = 7;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(126, 108);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 31);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtPrecioCarga
            // 
            this.txtPrecioCarga.Location = new System.Drawing.Point(77, 75);
            this.txtPrecioCarga.Name = "txtPrecioCarga";
            this.txtPrecioCarga.Size = new System.Drawing.Size(146, 22);
            this.txtPrecioCarga.TabIndex = 5;
            // 
            // lblPrecioCarga
            // 
            this.lblPrecioCarga.AutoSize = true;
            this.lblPrecioCarga.Location = new System.Drawing.Point(13, 78);
            this.lblPrecioCarga.Name = "lblPrecioCarga";
            this.lblPrecioCarga.Size = new System.Drawing.Size(50, 16);
            this.lblPrecioCarga.TabIndex = 4;
            this.lblPrecioCarga.Text = "Precio:";
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDestinoCarga.Location = new System.Drawing.Point(77, 47);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(146, 24);
            this.cmbDestinoCarga.TabIndex = 3;
            // 
            // lblDestinoCarga
            // 
            this.lblDestinoCarga.AutoSize = true;
            this.lblDestinoCarga.Location = new System.Drawing.Point(13, 50);
            this.lblDestinoCarga.Name = "lblDestinoCarga";
            this.lblDestinoCarga.Size = new System.Drawing.Size(59, 16);
            this.lblDestinoCarga.TabIndex = 2;
            this.lblDestinoCarga.Text = "Destino:";
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbOrigenCarga.Location = new System.Drawing.Point(77, 19);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(146, 24);
            this.cmbOrigenCarga.TabIndex = 1;
            // 
            // lblOrigenCarga
            // 
            this.lblOrigenCarga.AutoSize = true;
            this.lblOrigenCarga.Location = new System.Drawing.Point(13, 22);
            this.lblOrigenCarga.Name = "lblOrigenCarga";
            this.lblOrigenCarga.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenCarga.TabIndex = 0;
            this.lblOrigenCarga.Text = "Origen:";
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.btnBorrarConsulta);
            this.grpConsultaDatos.Controls.Add(this.btnConsultar);
            this.grpConsultaDatos.Controls.Add(this.txtPrecioConsulta);
            this.grpConsultaDatos.Controls.Add(this.lblPrecioConsulta);
            this.grpConsultaDatos.Controls.Add(this.cmbDestinoConsulta);
            this.grpConsultaDatos.Controls.Add(this.lblDestinoConsulta);
            this.grpConsultaDatos.Controls.Add(this.cmbOrigenConsulta);
            this.grpConsultaDatos.Controls.Add(this.lblOrigenConsulta);
            this.grpConsultaDatos.Location = new System.Drawing.Point(516, 52);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(244, 162);
            this.grpConsultaDatos.TabIndex = 2;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de Datos:";
            // 
            // btnBorrarConsulta
            // 
            this.btnBorrarConsulta.Location = new System.Drawing.Point(126, 108);
            this.btnBorrarConsulta.Name = "btnBorrarConsulta";
            this.btnBorrarConsulta.Size = new System.Drawing.Size(97, 31);
            this.btnBorrarConsulta.TabIndex = 7;
            this.btnBorrarConsulta.Text = "Borrar";
            this.btnBorrarConsulta.UseVisualStyleBackColor = true;
            this.btnBorrarConsulta.Click += new System.EventHandler(this.btnBorrarConsulta_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(16, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 31);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPrecioConsulta
            // 
            this.txtPrecioConsulta.Location = new System.Drawing.Point(77, 75);
            this.txtPrecioConsulta.Name = "txtPrecioConsulta";
            this.txtPrecioConsulta.Size = new System.Drawing.Size(146, 22);
            this.txtPrecioConsulta.TabIndex = 5;
            // 
            // lblPrecioConsulta
            // 
            this.lblPrecioConsulta.AutoSize = true;
            this.lblPrecioConsulta.Location = new System.Drawing.Point(13, 78);
            this.lblPrecioConsulta.Name = "lblPrecioConsulta";
            this.lblPrecioConsulta.Size = new System.Drawing.Size(50, 16);
            this.lblPrecioConsulta.TabIndex = 4;
            this.lblPrecioConsulta.Text = "Precio:";
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(77, 47);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(146, 24);
            this.cmbDestinoConsulta.TabIndex = 3;
            // 
            // lblDestinoConsulta
            // 
            this.lblDestinoConsulta.AutoSize = true;
            this.lblDestinoConsulta.Location = new System.Drawing.Point(13, 50);
            this.lblDestinoConsulta.Name = "lblDestinoConsulta";
            this.lblDestinoConsulta.Size = new System.Drawing.Size(59, 16);
            this.lblDestinoConsulta.TabIndex = 2;
            this.lblDestinoConsulta.Text = "Destino:";
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(77, 19);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(146, 24);
            this.cmbOrigenConsulta.TabIndex = 1;
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(13, 22);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenConsulta.TabIndex = 0;
            this.lblOrigenConsulta.Text = "Origen:";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.dgvMatriz);
            this.grpListado.Controls.Add(this.btnVerTodos);
            this.grpListado.Controls.Add(this.btnListarOrigenes);
            this.grpListado.Controls.Add(this.cmbHasta);
            this.grpListado.Controls.Add(this.lblHasta);
            this.grpListado.Controls.Add(this.btnListarDestinos);
            this.grpListado.Controls.Add(this.cmbDesde);
            this.grpListado.Controls.Add(this.lblDesde);
            this.grpListado.Location = new System.Drawing.Point(15, 224);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(745, 392);
            this.grpListado.TabIndex = 3;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listar viajes .......";
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrigen,
            this.colCordoba,
            this.colMendoza,
            this.colSantaFe,
            this.colBuenosAires,
            this.colSalta});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatriz.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatriz.Location = new System.Drawing.Point(15, 61);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersWidth = 51;
            this.dgvMatriz.RowTemplate.Height = 24;
            this.dgvMatriz.Size = new System.Drawing.Size(718, 283);
            this.dgvMatriz.TabIndex = 7;
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 6;
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.Width = 125;
            // 
            // colCordoba
            // 
            this.colCordoba.HeaderText = "Córdoba";
            this.colCordoba.MinimumWidth = 6;
            this.colCordoba.Name = "colCordoba";
            this.colCordoba.Width = 125;
            // 
            // colMendoza
            // 
            this.colMendoza.HeaderText = "Mendoza";
            this.colMendoza.MinimumWidth = 6;
            this.colMendoza.Name = "colMendoza";
            this.colMendoza.Width = 125;
            // 
            // colSantaFe
            // 
            this.colSantaFe.HeaderText = "Santa Fe";
            this.colSantaFe.MinimumWidth = 6;
            this.colSantaFe.Name = "colSantaFe";
            this.colSantaFe.Width = 125;
            // 
            // colBuenosAires
            // 
            this.colBuenosAires.HeaderText = "Buenos Aires";
            this.colBuenosAires.MinimumWidth = 6;
            this.colBuenosAires.Name = "colBuenosAires";
            this.colBuenosAires.Width = 125;
            // 
            // colSalta
            // 
            this.colSalta.HeaderText = "Salta";
            this.colSalta.MinimumWidth = 6;
            this.colSalta.Name = "colSalta";
            this.colSalta.Width = 125;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(618, 23);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(105, 25);
            this.btnVerTodos.TabIndex = 6;
            this.btnVerTodos.Text = "Ver todos los viajes";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(468, 23);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(96, 25);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbHasta.Location = new System.Drawing.Point(337, 23);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(111, 24);
            this.cmbHasta.TabIndex = 4;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(299, 27);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(163, 23);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(112, 25);
            this.btnListarDestinos.TabIndex = 2;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDesde.Location = new System.Drawing.Point(56, 23);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(107, 24);
            this.cmbDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(12, 27);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(49, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // frmGrafoMatricial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 628);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpConsultaDatos);
            this.Controls.Add(this.grpCargaDatos);
            this.Controls.Add(this.picGrafo);
            this.Name = "frmGrafoMatricial";
            this.Text = "Operaciones en un Grafo";
            ((System.ComponentModel.ISupportInitialize)(this.picGrafo)).EndInit();
            this.grpCargaDatos.ResumeLayout(false);
            this.grpCargaDatos.PerformLayout();
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrafo;
        private System.Windows.Forms.GroupBox grpCargaDatos;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtPrecioCarga;
        private System.Windows.Forms.Label lblPrecioCarga;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.Label lblDestinoCarga;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.Label lblOrigenCarga;
        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.Button btnBorrarConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPrecioConsulta;
        private System.Windows.Forms.Label lblPrecioConsulta;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.Label lblDestinoConsulta;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Label lblOrigenConsulta;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCordoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalta;
    }
}
