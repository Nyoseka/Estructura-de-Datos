using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P35.BusquedaSNumeros
{
    class Program
    {
        class BusquedaSecuencial
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

            public void Buscar()
            {
                bool found = false;
                int i = 0;
                int n = vector.Length - 1;
                Console.Write("Introduzca el elemento a buscar: ");
                key = int.Parse(Console.ReadLine());
                while(i<=n&found==false)
                {
                    if(key==vector[i])
                    {
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if(found==false)
                {
                    Console.WriteLine("El elemento {0} no está en el arreglo",key);
                }
                else
                {
                    Console.WriteLine("El elemento {0} está en la posición {1}",key,i+1);
                }
            }

        }
        static void Main(string[] args)
        {
            BusquedaSecuencial b = new BusquedaSecuencial();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU BUSQUEDA SECUENCIAL"+'\n');
                Console.WriteLine("1. Generar arreglo");
                Console.WriteLine("2. Desplegar y Buscar un elemento");
                Console.WriteLine("3. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:opcion=1;
                        {
                            Console.Clear();
                            b.Generar();
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
                            b.Imprimir();
                            Console.Write('\n');
                            b.Buscar();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            Console.Write("Pulse cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
