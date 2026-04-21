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
    public partial class frmEstructuraDinamicaLineal : Form
    {
        public frmEstructuraDinamicaLineal()
        {
            InitializeComponent();
        }

        private void frmEstructuraDinamicaLineal_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        clsCola fila = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);
            fila.Recorrer(dgvCola);
            fila.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtTramite.Text = "";
            txtNombre.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigoEliminado.Text = fila.Primero.Codigo.ToString();
                lblNombreEliminado.Text = fila.Primero.Nombre;
                lblTramiteEliminado.Text = fila.Primero.Tramite;

                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
            }
            else
            {
                MessageBox.Show("No hay elementos en la fila.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
