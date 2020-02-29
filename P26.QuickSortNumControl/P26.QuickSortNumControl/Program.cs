using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26.QuickSortNumControl
{
    class Program
    {
        class QuickSort
        {
            int[] vector = new int[50];
            public void Generar()
            {
                Random random = new Random();
                for (int c = 0; c <= 49; c++)
                {
                    vector[c] = random.Next(18210000, 18210100);
                }
            }
            public void Imprimir()
            {
                for (int c = 0; c <= 49; c++)
                {
                    Console.WriteLine((c + 1) + ". {0} ", vector[c]);
                }
            }

            public void Ordenar(int L, int R)
            {
                int i = L;
                int j = R;
                int w;
                int x = vector[(L + R) / 2];
                    do
                    {
                        while (vector[i] < x)
                        {
                            i++;
                        }
                        while (vector[j] > x)
                        {
                            j--;
                        }
                        if (i <= j)
                        {
                            w= vector[i];
                            vector[i] = vector[j];
                            vector[j] = w;
                            i++;
                            j--;
                        }
                    }
                    while (i < j);
                    if (L < j)
                    {
                        Ordenar(L, j);
                    }
                    if(i < R)
                    {
                        Ordenar(i, R);
                    }
            }
        }
        static void Main(string[] args)
        {
            QuickSort quick = new QuickSort();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU QUICKSORT");
                Console.WriteLine("1. Inicializar arreglo");
                Console.WriteLine("2. Desplazar el arreglo");
                Console.WriteLine("3. Ordenar el arreglo");
                Console.WriteLine("4. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            quick.Generar();
                            Console.WriteLine("Arreglo inicializado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO: ");
                            quick.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            quick.Ordenar(0,49);
                            Console.Write("Arreglo ordenado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            Console.Write("Pulsa cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción inválida");
                            break;
                        }
                }
            }
        }
    }
}
