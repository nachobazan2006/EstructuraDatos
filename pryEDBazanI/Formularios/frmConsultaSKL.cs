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

namespace pryEDBazanI.Formularios
{
    public partial class frmConsultaSKL : Form
    {
        public frmConsultaSKL()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)

        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvConsulta, txtConsulta.Text);

        }
        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
