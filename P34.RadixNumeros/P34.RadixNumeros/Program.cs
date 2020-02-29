using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P34.RadixNumeros
{
    class Program
    {
        class Nodo
        {
            public int info;
            public int next;
            public Nodo()
            { }
            public Nodo(int e,int n)
            {
                info = e;
                next = n;
            }
        }
        class RADIX
        {
            int[] rear = new int[10];
            int[] front = new int[11];
            Nodo[] node = new Nodo[50];
            int[] x = new int[50];
            int m = 8;
            int first;

            public void Generar()
            {
                Random random = new Random();
                for (int c = 0; c <= 49; c++)
                {
                    node[c].info = random.Next(18210000, 18210100);
                }
            }
            public void Imprimir()
            {
                    for (int c = 0; c <= 49; c++)
                    {
                        Console.WriteLine((c + 1) + ". {0} ", node[c].info);
                    }
            }
            public void Ordenar()
            {
                int n = node.Length - 1;
                int p, y, j, q, l;
                int expon;
                for(int i = 0; i !=n-1; i++)
                {
                    node[i].info = x[i];
                    node[i].next = i + 1;
                }
                node[n - 1].info = x[n - 1];
                node[n - 1].next = -1;
                first = 0;
                for (int k = 0; k <= m - 1; k++)
                {
                    for (int i = 0; i <= 9; i++)
                    {
                        rear[i] = -1;
                    }
                    for (int i = 0; i <= 10; i++)
                    {
                        front[i] = -1;
                    }
                    while (first != -1)
                    {
                        p = first;
                        first = node[first].next;
                        y = node[p].info;
                        expon = 1;
                        for (int i = 0; i != k; i++)
                        {
                            expon = expon * 10;
                        }
                        j = (y / expon) % 10;
                        q = rear[j];
                        if (q == -1)
                        {
                            front[j] = p;
                        }
                        else
                        {
                            node[q].next = p;
                        }
                        rear[j] = p;
                    }
                    j = 0;
                    while (j <= 9 & front[j] == -1)
                    {
                        j++;
                    }
                    first = front[j];
                    while (j <= 9)
                    {
                        l = j++;
                        while (l <= 9 & front[l] == -1)
                        {
                            l++;
                            if(l<=9)
                            {
                                p = l;
                                node[rear[l]].next = front[l];
                            }
                        }
                    }
                }
                for (int i = 0; i != n - 1; i++)
                {
                    x[i] = node[first].info;
                    first = node[first].next;
                }
            }
        }
        static void Main(string[] args)
        {
            RADIX r = new RADIX();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU RADIX");
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
                            r.Generar();
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
                            r.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            r.Ordenar();
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
