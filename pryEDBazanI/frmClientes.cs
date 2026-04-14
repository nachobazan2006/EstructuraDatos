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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes()
        {
            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NomArchi = "Clientes.csv";
            objCliente.Recorrer(dgvClientes);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtDeuda.Text == "")
            {
                MessageBox.Show("Debe completar todos los datos");
                return;
            }

            clsArchivoTexto objCliente = new clsArchivoTexto();
            objCliente.NomArchi = "Clientes.csv";
            objCliente.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);

            MessageBox.Show("Grabado");
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
            txtCodigo.Focus();
            ListarClientes();
        }
    }
}
