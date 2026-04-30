using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set { pri= value; }
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
    }
}
