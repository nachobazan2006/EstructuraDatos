namespace pryEDBazanI.Formularios
{
    partial class frmConsultaTabla
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 12);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(776, 348);
            this.dgvListado.TabIndex = 0;
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(523, 417);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(121, 21);
            this.cboLista.TabIndex = 1;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(454, 425);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(29, 13);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "Lista";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(665, 416);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(123, 21);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmConsultaTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmConsultaTabla";
            this.Text = "Consulta tabla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnListar;
    }
}