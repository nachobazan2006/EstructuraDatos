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
    public partial class frmConsultasConOperaciones : Form
    {
        public frmConsultasConOperaciones()
        {
            InitializeComponent();
            textBox1.Text = "SELECT Titulo, Precio FROM Libro WHERE Precio > 500";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dataGridView1, textBox1.Text);
        }
    }
}
