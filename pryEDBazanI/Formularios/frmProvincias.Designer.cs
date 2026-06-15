namespace pryEDBazanI
{
    partial class frmProvincias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lstProvincias = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una provincia:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(215, 63);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(196, 22);
            this.txtProvincia.TabIndex = 1;
            // 
            // lstProvincias
            // 
            this.lstProvincias.FormattingEnabled = true;
            this.lstProvincias.ItemHeight = 16;
            this.lstProvincias.Location = new System.Drawing.Point(61, 153);
            this.lstProvincias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstProvincias.Name = "lstProvincias";
            this.lstProvincias.Size = new System.Drawing.Size(349, 116);
            this.lstProvincias.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstProvincias);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProvincias";
            this.Text = "frmProvincias";
            this.Load += new System.EventHandler(this.frmProvincias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.ListBox lstProvincias;
        private System.Windows.Forms.Button button1;
    }
}