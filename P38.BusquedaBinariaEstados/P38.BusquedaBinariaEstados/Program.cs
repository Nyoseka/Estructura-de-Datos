using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P38.BusquedaBinariaEstados
{
    class Program
    {
        class BusquedaBinaria
        {
            string [] vector=new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };
            string key;

            public void Inicializar()
            {
                Random random = new Random();
                for (int c = 0; c <= 31; c++)
                {
                    string temp = vector[c];
                    int i = random.Next(0, 31);
                    vector[c] = vector[i];
                    vector[i] = temp;
                }
            }
            public void Imprimir()
            {
                for(int i=0; i<=31; i++)
                {
                    Console.WriteLine((i + 1) + ". {0} ", vector[i]);
                }
            }
            public void Ordenar()
            {
                string temp;
                int n = vector.Length - 1;
                for (int k = 1; k <= n - 1; k++)
                {
                    for (int l = 0; l <= n - k; l++)
                    {
                        if (string.Compare(vector[l], vector[l + 1]) > -1)
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
                int low = 0;
                int high = vector.Length - 1;
                int mid = 0;
                Console.Write("Indique el elemento a buscar: ");
                key = Console.ReadLine();
                while (low <= high & found == false)
                {
                    mid = (low + high) / 2;
                    if (vector[mid] == key)
                    {
                        found = true;
                    }
                    else
                    {
                        if (string.Compare(vector[mid],key) > 1)
                        {
                            high = mid - 1;
                        }
                        else
                        {
                            low = mid + 1;
                        }
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("El elemento {0} no está en el arreglo", key);
                }
                else
                {
                    Console.WriteLine("El elemento {0} está en la posición {1}", key, mid + 1);
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
                Console.WriteLine("MENÚ BUSQUEDA BINARIA" + '\n');
                Console.WriteLine("1. Inicializar arreglo");
                Console.WriteLine("2. Desplegar arreglo");
                Console.WriteLine("3. Ordenar arreglo");
                Console.WriteLine("4. Desplegar y buscar un elemento");
                Console.WriteLine("5. Salir del programa" + '\n');
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            bin.Inicializar();
                            Console.WriteLine("Arreglo inicializado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("Arreglo en desorden" + '\n');
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
                            break;
                        }
                }
            }
        }
    }
}
