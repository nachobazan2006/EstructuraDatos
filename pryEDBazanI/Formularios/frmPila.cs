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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila fila = new clsPila();
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
            if (fila.primero != null)
            {
                lblCodigoEliminado.Text = fila.primero.Codigo.ToString();
                lblNombreEliminado.Text = fila.primero.Nombre;
                lblTramiteEliminado.Text = fila.primero.Tramite;

                fila.Eliminar();
                fila.Recorrer(dgvCola);
                fila.Recorrer(lstCola);
            }
            else
            {
                MessageBox.Show("No hay elementos en la fila.");
            }
        }

    }
}
