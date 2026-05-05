using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBazanI.Clases
{
    class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        //propiedades 
        public clsNodo primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if (primero == null)
            {
                primero = Nvo;
                ultimo = Nvo;
            }
            else
            {
                clsNodo Aux = primero;
                clsNodo Ant = ultimo;
                ultimo = Nvo;
                while (Aux.Codigo < Nvo.Codigo)
                {
                    Ant = Aux;
                    Aux = Nvo;
                }
                Ant.Siguiente = Nvo;
                Nvo.Siguiente = Aux;
                Aux = Nvo;
                Nvo.Anterior = Ant; ;
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (primero == ultimo)
            {

            }
            else
            {
                if (ultimo.Codigo == Codigo)
                {
                    ultimo = ultimo.Siguiente;
                    ultimo.Siguiente = null;

                }
                else
                {
                    clsNodo aux = primero;
                    clsNodo ant = primero;
                    while (aux.Codigo < Codigo)
                    {
                        ant = aux;
                        aux = aux.Siguiente;
                    }
                    aux = aux.Siguiente;
                    aux.Anterior = ant;
                    ant.Siguiente = null;
                }
            }
        }
       
        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo aux = ultimo;

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
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(ListBox Lista)
        {
            clsNodo aux = ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDesc(ComboBox combo)
        {
            clsNodo aux = ultimo;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }


        }
    }
}
