using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDBazanI
{
     class clsCola
    {
        //campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //propiedades de la clase
        public clsNodo Primero 
        {
            get { return pri; }
            set { pri = value; }    
        }
        public clsNodo Ultimo 
        {
            get { return ult;  }
            set { ult = value; }
        }

        //Mètodos de la clase
        public void Agregar(clsNodo nuevo) 
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo = nuevo;
            }
            else 
            {
                Ultimo.Siguiente = nuevo;
                Ultimo= nuevo;
            }
        }
        public void Eliminar ()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else 
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            clsNodo aux= Primero;
            Grilla.Rows.Clear();
            while (aux != null) 
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux= aux.Siguiente ;
            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
    }
}
