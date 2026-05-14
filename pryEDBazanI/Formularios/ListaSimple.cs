using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryEDBazanI.Clases;

namespace pryEDBazanI
{
    public partial class ListaSimple : Form
    {
        clsListaSimple fila = new clsListaSimple();

        public ListaSimple()
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombree.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Lista simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombree.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);
            fila.Recorrer(dgvEnlazada);
            fila.Recorrer(lstEnlazada);
            fila.Recorrer(cmbElementoEliminado);

            txtCodigo.Text = "";
            txtNombree.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.primero != null)
            {
                if (cmbElementoEliminado.Text != "")
                {
                    fila.Eliminar(Convert.ToInt32(cmbElementoEliminado.Text));
                    fila.Recorrer(dgvEnlazada);
                    fila.Recorrer(lstEnlazada);
                    fila.Recorrer(cmbElementoEliminado);
                    cmbElementoEliminado.Text = "";
                }
                else
                {
                    MessageBox.Show("Seleccione un codigo para eliminar.", "Lista simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos en la lista.", "Lista simple", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
