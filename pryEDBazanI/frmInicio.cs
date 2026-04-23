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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador DD= new frmDatosDesarrollador();
            DD.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores COL = new frmColores();
            COL.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses MES = new frmMeses();
            MES.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes COM = new frmClientes();  
            COM.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos COM = new frmAlumnos();
            COM.ShowDialog();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstructuraDinamicaLineal COM = new frmEstructuraDinamicaLineal();
            COM.ShowDialog();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void díasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDias COM = new frmDias();    
            COM.ShowDialog();
        }

        private void ciudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades COM = new frmCiudades();
            COM.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias COM = new frmProvincias();
            COM.ShowDialog();
        }
    } 
}
