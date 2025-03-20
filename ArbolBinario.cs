using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArbolesChepeEchenPaja______
{
    class ArbolBinario
    {
        private Nodo root;

        public ArbolBinario()
        {
            root = new Nodo();
        }

        public void Add(int data)
        {
            if (root.Data == null)
            {
                root.Data = data;
                return;
            }

            Nodo path = root;
            while (path != null)
            {
                if (data > root.Data)
                {
                    path = path.Right;
                }

                else if (data < root.Data)
                {
                    path = path.Left;
                }
            }

            path = new Nodo(data);
            Console.WriteLine(data);
        }

        public void PreOrder()
        {

        }
    }
}
