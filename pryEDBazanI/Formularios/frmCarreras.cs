using System;
using System.Windows.Forms;

namespace pryEDBazanI
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            ListarCarreras();
        }

        private void ListarCarreras()
        {
            clsArchivoTexto archivo = new clsArchivoTexto();
            archivo.NomArchi = "Carreras.csv";
            archivo.Recorrer(lstCarreras);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto archivo = new clsArchivoTexto();
            archivo.NomArchi = "Carreras.csv";
            archivo.Grabar(txtNombre.Text);
            ListarCarreras();

            MessageBox.Show("Carrera grabada correctamente");
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGrabar.Enabled = txtNombre.Text != "";
        }
    }
}
