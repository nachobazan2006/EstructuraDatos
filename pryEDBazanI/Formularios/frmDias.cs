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
    public partial class frmDias : Form
    {
        public frmDias()
        {
            InitializeComponent();
        }
        public void CargarDias()
        {
            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Dias.txt";
            AD.Recorrer(lstDias);
        }   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDia.Text == "")
            {
                MessageBox.Show("Debe ingresar un dia");
                txtDia.Focus();
                return;
            }   
        clsArchivoTexto AD = new clsArchivoTexto();
        AD.NomArchi = "Dias.txt";
        AD.Grabar(txtDia.Text);
        CargarDias();
        }

        private void frmDias_Load(object sender, EventArgs e)
        {
            CargarDias();
        }
    }
}
