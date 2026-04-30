using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (primero.Codigo == Codigo)
            {
                primero = primero.Siguiente;
            }
            else 
            {
                clsNodo aux1 = primero;
                clsNodo aux2 = primero;
                while (aux1.Codigo != Codigo) 
                {
                    aux2 = aux2;
                    aux1 = aux1.Siguiente;
                }
                aux2.Siguiente = aux1.Siguiente;
            }
        }

    } 

}
