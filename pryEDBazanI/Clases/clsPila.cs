using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryEDBazanI
{
    internal class clsPila
    {
        //campos de la c lase
        private clsNodo pri;
        //propiedades de la clase
        //propiedaer por la cual accedemos al campo=primero
        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo nuevo)
        {

            if (primero == null)
            {
                primero = nuevo;
            }
            else 
            {
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
        }
        public void Eliminar()
        {
            if (primero == primero.Siguiente)
            {
                primero = null;
              
            }
            
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox combo)
        {
            clsNodo aux = primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }

    }
    }

