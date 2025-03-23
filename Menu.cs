using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArbolesChepeEchenPaja______
{
    class Menu
    {
        private int option, data;

        public Menu() { }

        // Metodo que muestra el menu en la consola
        public void Show()
        {
            Console.WriteLine("Arbol De Busqueda Binario");
            Console.WriteLine("=========================");

            ArbolBinario tree = new ArbolBinario();

            while (true)
            {
                Operations(tree, ref option);
                if (option == 6) return;
            }
        }

        // Metodo que muestra al usuario las operacines disponibles
        public void Operations(ArbolBinario tree, ref int option)
        {
            Thread.Sleep(500);
            Console.WriteLine("1. Agregar un valor al arbol");
            Console.WriteLine("2. Eliminar un valor del arbol");
            Console.WriteLine("3. Imprimir En PreOrden");
            Console.WriteLine("4. Imprimir En InOrden");
            Console.WriteLine("5. Imprimir En PostOrden");
            Console.WriteLine("6. Salir Del Programa");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Introduzca el dato que desea insertar al arbol: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    tree.Add(data);
                    break;
                case 2:
                    Console.Write("Introduzca el valor que desea eliminar del arbol: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    tree.Delete(data);
                    break;
                case 3:
                    tree.PreOrder();
                    Console.WriteLine();
                    break;
                case 4:
                    tree.InOrder();
                    Console.WriteLine();
                    break;
                case 5:
                    tree.PostOrder();
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Gracias Por Usar El Programa");
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;
            }
        }
    }
}
