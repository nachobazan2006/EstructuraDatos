using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBazanI.Clases
{
    class clsListaSimple
    {
        private clsNodo pri;

        //propiedades de la clase
        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }

        }
        public void Agregar(clsNodo Nuevo)
        {
            if (primero == null)
            {
                primero = Nuevo;
            }
            else 
            {
                if (Nuevo.Codigo <= primero.Codigo)
                {
                    Nuevo.Siguiente = primero;
                    primero = Nuevo;
                }
                else 
                {
                    clsNodo aux = primero;
                    clsNodo ant = primero;
                    while (Nuevo.Codigo > aux.Codigo) 
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                        if (aux == null) break;
                    }
                    Nuevo.Siguiente = aux;
                    ant.Siguiente = Nuevo;
                }

            }

        }
        public void Eliminar(Int32 Codigo) 
        {
            if (primero == null)
            {
                return;
            }

            if (primero.Codigo == Codigo)
            {
                primero = primero.Siguiente;
            }
            else 
            {
                clsNodo aux1 = primero;
                clsNodo aux2 = primero;
                while (aux1 != null && aux1.Codigo != Codigo) 
                {
                    aux2 = aux1;
                    aux1 = aux1.Siguiente;
                }

                if (aux1 != null)
                {
                    aux2.Siguiente = aux1.Siguiente;
                }
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

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = primero;

            if (Grilla.Columns.Count == 0)
            {
                Grilla.Columns.Add("Codigo", "Codigo");
                Grilla.Columns.Add("Nombre", "Nombre");
                Grilla.Columns.Add("Tramite", "Tramite");
            }

            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
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

    } 

}
