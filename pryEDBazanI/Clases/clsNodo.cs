using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDBazanI
{
     class clsNodo
    {
        //campos del nodo
        private Int32 cod;
        private string nom;
        private string tra;
        private clsNodo sig;

        private clsNodo ant;

        //propiedades del nodo
        public Int32 Codigo 
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre 
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Tramite 
        {
            get { return tra; }
            set { tra = value; }
        }
        public clsNodo Siguiente 
        {
            get { return sig; }
            set { sig = value; }
        }
        public clsNodo Anterior 
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}
