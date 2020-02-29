using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P39.HashNumeros
{
    class Program
    {
        class HASH
        {
            int[] vector = new int[50];
            int[] direcciones = new int[50];
            int key;
            int d, dx;

            public void Generar()
            {
                Random random = new Random();
                for (int c = 0; c <= 49; c++)
                {
                    vector[c] = random.Next(18210000, 18210100);

                }
            }

            public void InicializarV()
            {
                for (int s = 0; s < 50; s++)
                {
                    direcciones[s] = 0;
                }
            }

            public void Imprimir()
            {
                for (int c = 0; c <= 49; c++)
                {
                    Console.WriteLine("{0}. {1}", c + 1, vector[c]);
                }
            }

            public void AsignarDireccion()
            {
                int n = direcciones.Length - 1;
                for (int i=0; i<=n; i++)
                {
                    d = (vector[i] % n) + 1;
                    while(direcciones[d]!=0)
                    {
                        dx = d + 1;
                        if(dx>n)
                        {
                            d = 0;
                        }
                        else
                        {
                            d = dx;
                        }
                    }
                    direcciones[d] = vector[i];
                }
            }
            public void ImprimirDireccion()
            {
                    for (int c = 0; c <= 49; c++)
                    {
                        Console.WriteLine("{0}. {1}", c + 1, direcciones[c]);
                    }
            }
            public void Buscar()
            {
                int n = vector.Length-1;
                Console.Write("Ingrese un elemento a buscar: ");
                key = int.Parse(Console.ReadLine());
                d = (key % n) + 1;
                if(direcciones[d]==key)
                {
                    Console.WriteLine("El elemento {0} está en la posición {1}", key, d+1);
                }
                else
                {
                    dx = d + 1;
                    while((dx<=n)&&(direcciones[dx]!=key)&&(direcciones[dx]!=0)&&(dx!=d))
                    {
                        dx = d + 1;
                        if(dx>n)
                        {
                            dx = 0;
                        }
                    }
                    if(direcciones[dx]==key)
                    {
                        Console.WriteLine("El elemento {0} está en la posición {1}", key, dx+1);
                    }
                    else
                    {
                        Console.WriteLine("El elemento {0} no está en el arreglo", key);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            HASH hash = new HASH();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENÚ BUSQUEDA HASH"+'\n');
                Console.WriteLine("1. Generar arreglo K");
                Console.WriteLine("2. Desplegar arreglo K");
                Console.WriteLine("3. Generar direcciones");
                Console.WriteLine("4. Desplegar vector V y Buscar un elemento");
                Console.WriteLine("5. Salir del Programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            hash.Generar();
                            hash.InicializarV();
                            Console.WriteLine("Arreglo generado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO: " + '\n');
                            hash.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            hash.AsignarDireccion();
                            Console.WriteLine("Direcciones asignadas con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4: opcion = 4;
                        {
                            Console.Clear();
                            hash.ImprimirDireccion();
                            Console.WriteLine('\n');
                            hash.Buscar();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 5: opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
