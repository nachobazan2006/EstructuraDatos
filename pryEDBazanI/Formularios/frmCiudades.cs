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
    public partial class frmCiudades : Form
    {
      public frmCiudades()
        {
            InitializeComponent();
        }   

        private void CargarCiudades()
        {
            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Ciudades.txt";
            AD.Recorrer(lstCiudades);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                MessageBox.Show("Debe ingresar una ciudad");
                txtCiudad.Focus();
                return;
            }

            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Ciudades.txt";
            AD.Grabar(txtCiudad.Text);

            MessageBox.Show("Ciudad grabada correctamente");
            txtCiudad.Text = "";
            txtCiudad.Focus();
            CargarCiudades();
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            CargarCiudades();
        }
    }
}
