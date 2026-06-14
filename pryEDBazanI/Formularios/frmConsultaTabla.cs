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
    public partial class frmConsultaTabla : Form
    {
        public frmConsultaTabla()
        {
            InitializeComponent();
            cboLista.Items.Add("Autor");
            cboLista.Items.Add("Libro");
            cboLista.Items.Add("Idioma");
            cboLista.Items.Add("Pais");
            cboLista.SelectedIndex = 0;
        }

        private void frmConsultaTabla_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(cboLista.Text, dgvListado);
        }
    }
}
