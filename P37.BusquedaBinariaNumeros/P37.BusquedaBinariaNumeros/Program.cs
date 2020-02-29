using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P37.BusquedaBinariaNumeros
{
    class Program
    {
        class BusquedaBinaria
        {
            int[] vector = new int[50];
            int key;
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
            public void Ordenar()
            {
                int temp = 0;
                int n = vector.Length - 1;
                for (int k = 1; k <= n - 1; k++)
                {
                    for (int l = 0; l <= n - k; l++)
                    {
                        if (vector[l] > vector[l + 1])
                        {
                            temp = vector[l];
                            vector[l] = vector[l + 1];
                            vector[l + 1] = temp;
                        }
                    }
                }
            }
            public void Buscar()
            {
                bool found = false;
                int low=0;
                int high = vector.Length - 1;
                int mid=0;
                Console.Write("Indique el elemento a buscar: ");
                key = int.Parse(Console.ReadLine());
                while (low <= high & found == false)
                {
                    mid = (low + high) / 2;
                    if (vector[mid] == key)
                    {
                        found = true;
                    }
                    else
                    {
                        if (vector[mid] > key)
                        {
                            high = mid-1;
                        }
                        else
                        {
                            low=mid+1;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("El elemento {0} no está en el arreglo", key);
                }
                else
                {
                    Console.WriteLine("El elemento {0} está en la posición {1}", key, mid+1);
                }
            }
        }
        static void Main(string[] args)
        {
            BusquedaBinaria bin = new BusquedaBinaria();
            int opcion;
            Menu();
            void Menu()
            {
                Console.WriteLine("MENÚ BUSQUEDA BINARIA"+'\n');
                Console.WriteLine("1. Generar arreglo");
                Console.WriteLine("2. Desplegar arreglo");
                Console.WriteLine("3. Ordenar arreglo");
                Console.WriteLine("4. Desplegar y Buscar un elemento");
                Console.WriteLine("5. Salir del programa");
                Console.Write('\n'+"Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            bin.Generar();
                            Console.WriteLine("Arreglo generado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.WriteLine("Arreglo: " + '\n');
                            bin.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            bin.Ordenar();
                            Console.WriteLine("Arreglo ordenado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4: opcion = 4;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO: " + '\n');
                            bin.Imprimir();
                            Console.WriteLine('\n');
                            bin.Buscar();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 5: opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("Presione cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
