using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArbolesChepeEchenPaja______
{
    class Nodo
    {
        private int? data; // Dato que guarda el nodo
        private Nodo left; // Nodo siguiente a la izquierda
        private Nodo right; // Nodo siguiente a la derecha

        // Constructores de la clase Nodo
        public Nodo(int data, Nodo left, Nodo right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Nodo(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public Nodo()
        {
            data = null;
            left = null;
            right = null;
        }

        // Getters y setters de la clase Nodo
        public int? Data
        {
            get { return data; }
            set { data = value; }
        }

        public Nodo Left
        {
            get { return left; }
            set { left = value; }
        }

        public Nodo Right
        {
            get { return right; }
            set { right = value; }
        }
    }
}
