using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P24.ShellNumControl
{
    class Program
    {
        class ShellSort
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

            public void Ordenamiento()
            {
                int n = vector.Length-1;
                int[]incremento = new int[] { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
                for (int m = incremento.Length-1; m >= 0; m--)
                {
                    int h = incremento[m];

                    for (int j = h; j <= n; j++)
                    {
                        int i = j-h;
                        int k = vector[j];

                        while (i >= 0 && k <= vector[i])
                        {
                            vector[i + h] = vector[i];
                            i = i - h;
                        }
                        vector[i + h] = k;
                    }
                }
            }
        }
            static void Main(string[] args)
            {
                ShellSort shell = new ShellSort();
                int opcion;
                Menu();

                void Menu()
                {
                    Console.WriteLine("MENU SHELL");
                    Console.WriteLine("1. Generar arreglo");
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
                                shell.Generar();
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
                                shell.Imprimir();
                                Console.ReadKey();
                                Console.Clear();
                                Menu();
                                break;
                            }
                        case 3:
                            opcion = 3;
                            {
                                Console.Clear();
                                shell.Ordenamiento();
                                Console.WriteLine("Arreglo ordenado con éxito");
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
