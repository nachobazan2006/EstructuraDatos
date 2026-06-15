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
                if (Nvo.Codigo <= primero.Codigo)
                {
                    Nvo.Siguiente = primero;
                    primero.Anterior = Nvo;
                    primero = Nvo;
                }
                else
                {
                    clsNodo Aux = primero;
                    clsNodo Ant = primero;

                    while (Aux != null && Nvo.Codigo > Aux.Codigo)
                    {
                        Ant = Aux;
                        Aux = Aux.Siguiente;
                    }

                    Nvo.Siguiente = Aux;
                    Nvo.Anterior = Ant;
                    Ant.Siguiente = Nvo;

                    if (Aux != null)
                    {
                        Aux.Anterior = Nvo;
                    }
                    else
                    {
                        ultimo = Nvo;
                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (primero == null)
            {
                return;
            }

            if (primero == ultimo)
            {
                if (primero.Codigo == Codigo)
                {
                    primero = null;
                    ultimo = null;
                }
            }
            else
            {
                if (primero.Codigo == Codigo)
                {
                    primero = primero.Siguiente;
                    primero.Anterior = null;
                }
                else
                {
                    if (ultimo.Codigo == Codigo)
                    {
                        ultimo = ultimo.Anterior;
                        ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo aux = primero;

                        while (aux != null && aux.Codigo != Codigo)
                        {
                            aux = aux.Siguiente;
                        }

                        if (aux != null)
                        {
                            aux.Anterior.Siguiente = aux.Siguiente;
                            aux.Siguiente.Anterior = aux.Anterior;
                        }
                    }
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
        public void RecorrerAsc(DataGridView Grilla)
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
        public void RecorrerAsc(ListBox Lista)
        {
            clsNodo aux = primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerAsc(ComboBox combo)
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
