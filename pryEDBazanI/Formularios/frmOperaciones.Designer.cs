namespace pryEDBazanI.Formularios
{
    partial class frmOperaciones
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
            this.dgvBaseDatos = new System.Windows.Forms.DataGridView();
            this.grpProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.grpSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionPorConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.grpAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).BeginInit();
            this.grpProyeccion.SuspendLayout();
            this.grpSeleccion.SuspendLayout();
            this.grpAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDatos
            // 
            this.dgvBaseDatos.AllowUserToAddRows = false;
            this.dgvBaseDatos.AllowUserToDeleteRows = false;
            this.dgvBaseDatos.AllowUserToOrderColumns = true;
            this.dgvBaseDatos.AllowUserToResizeRows = false;
            this.dgvBaseDatos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvBaseDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDatos.Location = new System.Drawing.Point(12, 12);
            this.dgvBaseDatos.Name = "dgvBaseDatos";
            this.dgvBaseDatos.Size = new System.Drawing.Size(776, 265);
            this.dgvBaseDatos.TabIndex = 0;
            // 
            // grpProyeccion
            // 
            this.grpProyeccion.Controls.Add(this.btnJuntar);
            this.grpProyeccion.Controls.Add(this.btnProyeccionMultiatributo);
            this.grpProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.grpProyeccion.Location = new System.Drawing.Point(12, 293);
            this.grpProyeccion.Name = "grpProyeccion";
            this.grpProyeccion.Size = new System.Drawing.Size(245, 134);
            this.grpProyeccion.TabIndex = 1;
            this.grpProyeccion.TabStop = false;
            this.grpProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(14, 96);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(217, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(14, 60);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(217, 23);
            this.btnProyeccionMultiatributo.TabIndex = 1;
            this.btnProyeccionMultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(14, 25);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(217, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // grpSeleccion
            // 
            this.grpSeleccion.Controls.Add(this.btnSeleccionPorConvolucion);
            this.grpSeleccion.Controls.Add(this.btnSeleccionMultiatributo);
            this.grpSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.grpSeleccion.Location = new System.Drawing.Point(277, 293);
            this.grpSeleccion.Name = "grpSeleccion";
            this.grpSeleccion.Size = new System.Drawing.Size(245, 134);
            this.grpSeleccion.TabIndex = 2;
            this.grpSeleccion.TabStop = false;
            this.grpSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSeleccionPorConvolucion
            // 
            this.btnSeleccionPorConvolucion.Location = new System.Drawing.Point(14, 96);
            this.btnSeleccionPorConvolucion.Name = "btnSeleccionPorConvolucion";
            this.btnSeleccionPorConvolucion.Size = new System.Drawing.Size(217, 23);
            this.btnSeleccionPorConvolucion.TabIndex = 2;
            this.btnSeleccionPorConvolucion.Text = "Selección por convolución";
            this.btnSeleccionPorConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(14, 60);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(217, 23);
            this.btnSeleccionMultiatributo.TabIndex = 1;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(14, 25);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(217, 23);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // grpAlgebraicas
            // 
            this.grpAlgebraicas.Controls.Add(this.btnDiferencia);
            this.grpAlgebraicas.Controls.Add(this.btnInterseccion);
            this.grpAlgebraicas.Controls.Add(this.btnUnion);
            this.grpAlgebraicas.Location = new System.Drawing.Point(543, 293);
            this.grpAlgebraicas.Name = "grpAlgebraicas";
            this.grpAlgebraicas.Size = new System.Drawing.Size(245, 134);
            this.grpAlgebraicas.TabIndex = 3;
            this.grpAlgebraicas.TabStop = false;
            this.grpAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(14, 96);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(217, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(14, 60);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(217, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(14, 25);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(217, 23);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAlgebraicas);
            this.Controls.Add(this.grpSeleccion);
            this.Controls.Add(this.grpProyeccion);
            this.Controls.Add(this.dgvBaseDatos);
            this.Name = "frmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDatos)).EndInit();
            this.grpProyeccion.ResumeLayout(false);
            this.grpSeleccion.ResumeLayout(false);
            this.grpAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDatos;
        private System.Windows.Forms.GroupBox grpProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox grpSeleccion;
        private System.Windows.Forms.Button btnSeleccionPorConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox grpAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}
