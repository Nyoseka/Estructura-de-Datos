using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22.BurbujaNumControl
{
    class Program
    {
        class Burbuja
        {
            int[] vector=new int[50];

            public void Generar()
            {
                Random random = new Random();
                for(int c=0; c<=49; c++)
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
            public void OrdenamientoBurbuja()
            {
                int temp=0;
                int n = vector.Length-1;
                for(int k = 1; k <=n-1; k++)
                {
                    for(int l = 0; l <=n-k; l++)
                    {
                        if(vector[l]>vector[l+1])
                        {
                            temp = vector[l];
                            vector[l] = vector[l + 1];
                            vector[l + 1] = temp;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Burbuja burbuja = new Burbuja();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU METODO DE BURBUJA");
                Console.WriteLine("1. Generar arreglo");
                Console.WriteLine("2. Desplazar el arreglo");
                Console.WriteLine("3. Ordenar el arreglo");
                Console.WriteLine("4. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            burbuja.Generar();
                            Console.WriteLine("Arreglo inicializado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO: ");
                            burbuja.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO ORDENADO CON ÉXITO ");
                            burbuja.OrdenamientoBurbuja();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4: opcion = 4;
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
