using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDBazanI
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void ListarMeses()
        {
            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Meses.txt";
            AD.Recorrer(lstMeses);
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            ListarMeses();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un mes");
                txtNombre.Focus();
                return;
            }

            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Meses.txt";
            AD.Grabar(txtNombre.Text);

            MessageBox.Show("Mes grabado correctamente");
            txtNombre.Text = "";
            txtNombre.Focus();
            ListarMeses();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarMeses();
        }
    }
}
