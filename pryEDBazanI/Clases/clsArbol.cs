using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDBazanI.Clases
{
    internal class clsArbol
    {
        private clsNodo Raiz;

        public void Agregar(clsNodo Nvo) 
        {
            if (Nvo == null)
            {
                Raiz = Nvo;
            }
            else 
            {
                clsNodo Ant = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null) 
                {
                    Ant = Aux;
                    if (Nvo.Codigo < Aux.Codigo) 
                    {
                        Aux = Aux.Izquierda;
                    }
                    else 
                    {
                        Aux = Aux.Derecha;
                    }
                }
                if (Nvo.Codigo < Ant.Codigo) Ant.Izquierda = Nvo;
                else Ant.Derecha = Nvo;

            }
        }
        public void Recorrer(DataGridView Grilla) 
        {
            Grilla.Rows.Clear();
            InOrderAsc(Grilla, Raiz);

        }   
        public void InOrderAsc(DataGridView Dgv, clsNodo R) 
        {
            if (R.Izquierda !=null) InOrderAsc (Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecha != null) InOrderAsc(Dgv, R.Derecha);
        }
    }
}
