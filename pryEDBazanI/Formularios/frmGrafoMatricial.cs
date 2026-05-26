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
    public partial class frmGrafoMatricial : Form
    {
        public frmGrafoMatricial()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            cmbOrigenCarga.SelectedIndex = 0;
            cmbDestinoCarga.SelectedIndex = 0;
            cmbOrigenConsulta.SelectedIndex = 0;
            cmbDestinoConsulta.SelectedIndex = 0;
            cmbDesde.SelectedIndex = 0;
            cmbHasta.SelectedIndex = 0;

            dgvMatriz.Rows.Add("Córdoba", "0", "0", "0", "0", "0");
            dgvMatriz.Rows.Add("Mendoza", "0", "0", "0", "0", "0");
            dgvMatriz.Rows.Add("Santa Fe", "0", "0", "0", "0", "0");
            dgvMatriz.Rows.Add("Buenos Aires", "0", "0", "0", "0", "0");
            dgvMatriz.Rows.Add("Salta", "0", "0", "0", "0", "0");
        }
    }
}
