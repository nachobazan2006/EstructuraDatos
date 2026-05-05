using pryEDBazanI.Clases;
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
    public partial class frmListaDobleEnlazada : Form
    {
        public frmListaDobleEnlazada()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
        clsListaDoble fila= new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombree.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Lista doble", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombree.Text;
            n.Tramite = txtTramite.Text;

            fila.Agregar(n);

            if (rbDescendente.Checked == true)
            {
                fila.RecorrerDesc(dgvEnlazada);
                fila.RecorrerDesc(lstEnlazada);
            }
            else
            {
                MessageBox.Show("Seleccione Descendente para listar la lista doble.", "Lista doble", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtCodigo.Text = "";
            txtTramite.Text = "";
            txtNombree.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.ultimo != null) 
            {
                
                    cmbElementoEliminado.Text = fila.ultimo.Codigo.ToString();
                    

                    fila.Eliminar();
                    fila.RecorrerDesc(dgvEnlazada);
                    fila.RecorrerDesc(lstEnlazada);
               
            }
           
            else
            {
                MessageBox.Show("No hay elementos en la fila.");
            }
        }
    }
}

