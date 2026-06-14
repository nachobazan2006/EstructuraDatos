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

namespace pryEDBazanI.Formularios
{
    public partial class frmArbol : Form
    {
        clsArbol Arbol = new clsArbol();

        public frmArbol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos.", "Arbol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            Arbol.Agregar(n);
            Arbol.Recorrer(dgvArbol);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvArbol);
        }
    }
}
