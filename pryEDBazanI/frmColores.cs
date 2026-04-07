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
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                MessageBox.Show("Debe ingresar un color");
                return;
            }

            clsArchivoTexto AD = new clsArchivoTexto();
            AD.NomArchi = "Colores.txt";    
            AD.Grabar(txtColor.Text);

            MessageBox.Show("Color grabado correctamente");

            
        }

        private void frmColores_Load(object sender, EventArgs e)
        {

        }
    }
}
