using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8.BusquedaBinaria
{
    class Program
    {
        public class BBinaria
        {
            public int Busqueda(int[] a, int key, int low, int high)
            {
                {
                    if (low > high)
                    {
                        return -1;
                    }
                    int mid = (low + high) / 2;
                    if (key == a[mid])
                    {
                        return mid;
                    }
                    else if (key < a[mid])
                    {
                        return Busqueda(a, key, low, mid - 1);
                    }
                    else
                    {
                        return Busqueda(a, key, mid + 1, high);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            BBinaria binaria = new BBinaria();
            Random r = new Random();
            int[] a = new int[10];
            int opcion;
            int num;
            int low = 0;
            int high = 9;
            int key;
            Console.WriteLine("MENU BUSQUEDA BINARIA" + '\n');
            Console.WriteLine("1. Generar arreglo");
            Console.WriteLine("2. Buscar elemento");
            Console.WriteLine("3. Salir" + '\n');
            Console.Write("Selecciona una opcion ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    opcion = 1;
                    {
                        Console.Clear();
                        for (int c = 0; c <= 9; c++)
                        {
                            num = r.Next(1, 10);
                            a[c] = num;
                        }
                        for (int i = 0; i <= 9; i++)
                        {
                            Console.Write(a[i] + " ");
                        }
                        Console.WriteLine('\n');
                        break;
                    }
                case 2:
                    opcion = 2;
                    {
                        Console.Clear();
                        for (int c = 0; c <= 9; c++)
                        {
                            num = r.Next(1, 10);
                            a[c] = num;
                        }
                        for (int i = 0; i <= 9; i++)
                        {
                            Console.Write(a[i] + " ");
                        }
                        Console.WriteLine('\n');
                        Console.Write("Ingresa el numero a buscar: ");
                        key = int.Parse(Console.ReadLine());
                        Console.WriteLine("Posicion del elemento: " + binaria.Busqueda(a, key, low, high));
                        break;
                    }
                case 3:
                    opcion = 3;
                    {
                        Console.Clear();
                        break;
                    }
            }
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
