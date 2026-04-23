using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


//IO INput output, es decir, entrada o salida de datos, en este caso, de archivos de texto. Para poder usar esta clase, se debe importar el espacio de nombres System.IO.
namespace pryEDBazanI
{
    internal class clsArchivoTexto
    {
        public string NomArchi = "Colores.txt";

        //Creamos procedimientos 
        public void Grabar()
        {

            StreamWriter AD = new StreamWriter(NomArchi);
            AD.Write("Hola");
            AD.Close();
        }
        public void Grabar(string Dato)
        {

            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();
        }
        public void Grabar(string codigo, string nombre)
        {

            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(codigo); //contenido de la variable sin enter
            AD.Write(";");
            AD.WriteLine(nombre); //contenido de la variable + enter
            AD.Close();
        }
        public void Grabar(string Dato1, string Dato2, string Dato3)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //abrir AD para escritura
            AD.Write(Dato1); //Escribir el contenido de la variable (sin enter)
            AD.Write(";"); //ESCRIBIR punto y coma (sin enter)
            AD.Write(Dato2);
            AD.Write(";");
            AD.WriteLine(Dato3);
            AD.Close();
        }
        public void Recorrer(ComboBox lst)
        {
            string DatoLeido;
            lst.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido =AD.ReadLine();
            }
            AD.Close();
            lst.SelectedIndex = 0;
        }
        public void Recorrer(ListBox lst)
        {
            string DatoLeido;
            lst.Items.Clear();

            if (File.Exists(NomArchi) == false)
            {
                return;
            }

            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lst.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer(DataGridView Grilla) 
        {
            string DatoLeido;   
            Grilla.Rows.Clear();

            if (File.Exists(NomArchi) == false)
            {
                return;
            }

            StreamReader AD= new StreamReader(NomArchi);
            DatoLeido=AD.ReadLine();
            while (DatoLeido != null) 
            {
                Grilla.Rows.Add(DatoLeido.Split(';') );
                DatoLeido =AD.ReadLine();
            }
            AD.Close ();
        }
    }
}
