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
        private Nodo root; // Nodo raiz del arbol binario

        // Constructores de la clase ArbolBinario
        public ArbolBinario()
        {
            root = new Nodo();
        }

        public ArbolBinario(int data)
        {
            root = new Nodo(data);
        }

        // Metodo que inserta un valor al arbol
        public void Add(int data)
        {
            // Si el arbol esta vacio agrega el valor como la raiz
            if (root.Data == null)
            {
                root.Data = data;
                return;
            }

            Nodo path = root;
            while (true)
            {
                // Si el valor ya se encuentra en el arbol retorna
                if (data == path.Data) return;

                // Si es mayor a la raiz busca insetarlo en el lado derecho del arbol
                if (data > path.Data)
                {
                    if (path.Right == null)
                    {
                        path.Right = new Nodo(data);
                        return;
                    }
                    path = path.Right;
                }

                // Si es menor a la raiz busca insetarlo en el lado izquierdo del arbol
                else if (data < path.Data)
                {
                    if (path.Left == null)
                    {
                        path.Left = new Nodo(data);
                        return;
                    }
                    path = path.Left;
                }
            }
        }

        // Metodo que imprime el arbol en PreOrden
        private void PreOrder(Nodo Nodo)
        {
            Console.Write(Nodo.Data + " ");

            if (Nodo.Left != null)
            {
                PreOrder(Nodo.Left);
            }

            if (Nodo.Right != null)
            {
                PreOrder(Nodo.Right);
            }
        }

        public void PreOrder() { PreOrder(root); }

        // Metodo que imprime el arbol en InOrden
        private void InOrder(Nodo Nodo)
        {
            if (Nodo.Left != null)
            {
                InOrder(Nodo.Left);
            }

            Console.Write(Nodo.Data + " ");

            if (Nodo.Right != null)
            {
                InOrder(Nodo.Right);
            }
        }

        public void InOrder() { InOrder(root); }

        // Metodo que imprime el arbol en PreOrden
        private void PostOrder(Nodo Nodo)
        {
            if (Nodo.Left != null)
            {
                PostOrder(Nodo.Left);
            }

            if (Nodo.Right != null)
            {
                PostOrder(Nodo.Right);
            }

            Console.Write(Nodo.Data + " ");
        }

        public void PostOrder() { PostOrder(root); }

        // Metodo que elmina un dato del arbol
        public void Delete(int data)
        {
            // Si el arbol esta vacio retorna
            if (root == null) return;

            // Si el dato no esta en el arbol retorna
            if (!IsInTheTree(data)) return;

            Nodo Nodo = FindNodo(data);
            Nodo parent = FindParent(data);

            // Si el nodo es una hoja elimina el nodo
            if (IsALeaf(Nodo))
            {
                DeleteLeaf(parent, data);
            }

            // Si el nodo tiene dos subarboles como hijos pone el valor más pequeño del subarbol derecho  en el lugar del dato eliminado y elimina el nodo con el valor mas pequeño del arbol
            else if (Nodo.Left != null && Nodo.Right != null)
            {
                Nodo minValueNodo = FindMinValue(Nodo.Right);
                Nodo minValueParent = FindParent((int)minValueNodo.Data);

                Nodo.Data = minValueNodo.Data;

                // Si el subarbol derecho no tiene hijos a la izquierda, el nodo padre del subarbol toma el valor de su hijo a la derecha
                if (minValueParent == Nodo)
                {
                    Nodo.Right = Nodo.Right.Right;
                }

                else
                {
                    minValueParent.Left = null;
                }
            }

            // Si el nodo tiene un subarbol a la izquierda o derecha, el subarbol reemplaza el nodo eliminado
            else if (Nodo.Left != null)
            {
                Nodo.Data = Nodo.Left.Data;
                Nodo.Left = null;
            }

            else
            {
                Nodo.Data = Nodo.Right.Data;
                Nodo.Right = null;
            }
        }

        // Metodo que checa si un valor existe en el arbol
        private bool IsInTheTree(int data)
        {
            Nodo temp = root;

            while (temp != null)
            {
                if (data == temp.Data) return true;

                else if (data < temp.Data)
                {
                    temp = temp.Left;
                }

                else
                {
                    temp = temp.Right;
                }
            }
            return false;
        }

        // Metodo que encuentra el nodo en que se encuentra un dato y lo retorna
        private Nodo FindNodo(int data)
        {
            Nodo temp = root;

            while (true)
            {
                if (data == temp.Data) return temp;

                else if (data < temp.Data)
                {
                    temp = temp.Left;
                }

                else
                {
                    temp = temp.Right;
                }
            }
        }

        // Metodo que encuentra el padre de un nodo en base al dato de ese nodo y lo retorna
        private Nodo FindParent(int data)
        {
            Nodo temp = root;

            while (true)
            {
                if (temp.Left != null && data == temp.Left.Data) return temp;

                if (temp.Right != null && data == temp.Right.Data) return temp;

                else if (data < temp.Data)
                {
                    temp = temp.Left;
                }

                else
                {
                    temp = temp.Right;
                }
            }
        }

        // Metodo que encuentra el valor mas pequeño en un subarbol
        private Nodo FindMinValue(Nodo Nodo)
        {
            while (true)
            {
                if (Nodo.Left == null) return Nodo;

                else
                {
                    Nodo = Nodo.Left;
                }
            }
        }

        // Metodo que elimina una hoja
        private void DeleteLeaf(Nodo Nodo, int data)
        {
            if (Nodo.Left != null && Nodo.Left.Data == data)
            {
                Nodo.Left = null;
            }
            else
            {
                Nodo.Right = null;
            }
        }

        // Metodo que checa si un nodo es una hoja
        private bool IsALeaf(Nodo Nodo)
        {
            if (Nodo.Left == null && Nodo.Right == null) return true;

            else return false;
        }
    }
}
