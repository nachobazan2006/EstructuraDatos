using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBazanI
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void CargarCarreras()
        {
            clsArchivoTexto objCarrera = new clsArchivoTexto();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.Recorrer(cmbCarrera);
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            CargarCarreras();

            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            objAlumnos.NomArchi = "Alumnos.csv";
            if (File.Exists(objAlumnos.NomArchi))
            {
                objAlumnos.Recorrer(dgvAlumnos);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || cmbCarrera.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos.");
                return;
            }

            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            objAlumnos.NomArchi = "Alumnos.csv";
            objAlumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objAlumnos.Recorrer(dgvAlumnos);

            txtCodigo.Clear();
            txtNombre.Clear();
            if (cmbCarrera.Items.Count > 0)
            {
                cmbCarrera.SelectedIndex = 0;
            }
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargarCarreras_Click(object sender, EventArgs e)
        {
            frmCarreras frm = new frmCarreras();
            frm.ShowDialog();
            CargarCarreras();
        }
    }
}
