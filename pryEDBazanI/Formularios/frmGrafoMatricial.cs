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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtPrecioCarga.Text == "")
            {
                MessageBox.Show("Ingrese un precio.", "Grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Int32 Origen = cmbOrigenCarga.SelectedIndex;
            Int32 Destino = cmbDestinoCarga.SelectedIndex + 1;

            dgvMatriz.Rows[Origen].Cells[Destino].Value = txtPrecioCarga.Text;
            txtPrecioCarga.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 Origen = cmbOrigenConsulta.SelectedIndex;
            Int32 Destino = cmbDestinoConsulta.SelectedIndex + 1;

            txtPrecioConsulta.Text = dgvMatriz.Rows[Origen].Cells[Destino].Value.ToString();
        }

        private void btnBorrarConsulta_Click(object sender, EventArgs e)
        {
            txtPrecioConsulta.Text = "";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            for (Int32 f = 0; f < dgvMatriz.Rows.Count; f++)
            {
                for (Int32 c = 1; c < dgvMatriz.Columns.Count; c++)
                {
                    dgvMatriz.Rows[f].Cells[c].Value = "0";
                }
            }

            txtPrecioCarga.Text = "";
            txtPrecioConsulta.Text = "";
        }

        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 Origen = cmbDesde.SelectedIndex;
            String Texto = "Destinos desde " + cmbDesde.Text + ":" + Environment.NewLine;

            for (Int32 c = 1; c < dgvMatriz.Columns.Count; c++)
            {
                if (dgvMatriz.Rows[Origen].Cells[c].Value.ToString() != "0")
                {
                    Texto = Texto + dgvMatriz.Columns[c].HeaderText + " - $" + dgvMatriz.Rows[Origen].Cells[c].Value.ToString() + Environment.NewLine;
                }
            }

            MessageBox.Show(Texto, "Grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 Destino = cmbHasta.SelectedIndex + 1;
            String Texto = "Origenes hacia " + cmbHasta.Text + ":" + Environment.NewLine;

            for (Int32 f = 0; f < dgvMatriz.Rows.Count; f++)
            {
                if (dgvMatriz.Rows[f].Cells[Destino].Value.ToString() != "0")
                {
                    Texto = Texto + dgvMatriz.Rows[f].Cells[0].Value.ToString() + " - $" + dgvMatriz.Rows[f].Cells[Destino].Value.ToString() + Environment.NewLine;
                }
            }

            MessageBox.Show(Texto, "Grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La matriz muestra todos los viajes cargados.", "Grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
