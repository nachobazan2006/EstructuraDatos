using System;
using System.Drawing;
using System.Windows.Forms;

namespace pryEDBazanI
{
    public partial class frmDatosDesarrollador : Form
    {
        public frmDatosDesarrollador()
        {
            InitializeComponent();
        }

        private void frmDatosDesarrollador_Load(object sender, EventArgs e)
        {
            lblEdadValor.Text = "19 años";
            lblCarreraValor.Text = "Analista de Sistemas";
            lblRolValor.Text = "Desarrollador C# / .NET";
            lblEstadoValor.Text = "Aprendizaje constante y enfoque practico";
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.FromArgb(245, 248, 255);
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                panel.BackColor = Color.White;
            }
        }

        private void lblEdadValor_Click(object sender, EventArgs e)
        {

        }
    }
}
