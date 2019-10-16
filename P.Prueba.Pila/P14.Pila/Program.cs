using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14.Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miPila = new Stack();

            int opcion;

            do
            {
                Console.Clear();

                opcion = menu();

                switch (opcion)
                {
                    case 1:
                        agregar(ref miPila);
                        break;
                    case 2:
                        eliminar(ref miPila);
                        break;
                    case 3:
                        limpiar(ref miPila);
                        break;
                    case 4:
                        imprimir(miPila);
                        break;
                    case 5: break;
                    default:
                        mensaje("ERROR: la opción no es valida. Intente de nuevo.");
                        break;
                }

            }
            while (opcion != 5);

            mensaje("El programa ha finalizado.");
        }

        static void agregar(ref Stack pila)
        {
            Console.Write("\n>Ingrese valor: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 99 || valor <= 0)
                {
                    mensaje("Solo números del 1 al 99");
                }
                else
                {
                    pila.Push(valor);
                    imprimir(pila);
                }
            }
            catch
            {
                mensaje("Error: Solo números del 1 al 99");
            }

        }
        static void limpiar(ref Stack pila)
        {
            pila.Clear();
            imprimir(pila);
        }

        static void eliminar(ref Stack pila)
        {
            if (pila.Count > 0)
            {
                int valor = (int)pila.Pop();
                mensaje("Elemento " + valor + " eliminado");
            }
            else
            {
            }

        }
        static int menu()
        {
            Console.WriteLine("\n            Stack Menu\n");
            Console.WriteLine(" 1.- Agregar elemento");
            Console.WriteLine(" 2.- Eliminar elemento");
            Console.WriteLine(" 3.- Vaciar Pila");
            Console.WriteLine(" 4.- Ver pila");
            Console.WriteLine(" 5.- Termina programa");
            Console.Write(" JC:> Ingresa tu opción: ");
            try
            {
                int valor = Convert.ToInt32(Console.ReadLine());
                return valor;
            }
            catch
            {
                return 0;
            }
        }

        static void mensaje(String texto)
        {
            if (texto.Length > 0)
            {
                Console.WriteLine("\n    =======================================================");
                Console.WriteLine(" JC:> {0}", texto);
                Console.WriteLine(" =======================================================");
                Console.WriteLine("\n    JC:>Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }


        static void imprimir(Stack pila)
        {
            if (pila.Count > 0)
            {
                Console.WriteLine("");
                foreach (int dato in pila)
                {
                    Console.WriteLine(" | |");
                    if (dato < 10)
                        Console.WriteLine(" | 0{0} |", dato);
                    else
                        Console.WriteLine(" | {0} |", dato);
                    Console.WriteLine(" |______|");
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                mensaje("La Pila esta vacia");
            }
        }
    }
}
