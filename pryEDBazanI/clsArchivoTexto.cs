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
        public void Recorrer()
        {
            string DatoLeido;
            
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            


        }
    }
}
