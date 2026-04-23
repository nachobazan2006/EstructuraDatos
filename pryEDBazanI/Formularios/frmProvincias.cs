using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBazanI
{
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }
        public void CargarProvincias() 
        {
            clsArchivoTexto AD= new clsArchivoTexto();
            AD.NomArchi = "Provincias.txt";
            AD.Recorrer(lstProvincias);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProvincia.Text == "")
            {
                MessageBox.Show("Debe ingresar una provincia");
                txtProvincia.Focus();
                return;
            }
            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Provincias.txt";
            AD.Grabar(txtProvincia.Text);
            MessageBox.Show("Provincia grabada correctamente");
            txtProvincia.Text = "";
            txtProvincia.Focus();
            CargarProvincias();
        }

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            CargarProvincias();
        }
    }
}
