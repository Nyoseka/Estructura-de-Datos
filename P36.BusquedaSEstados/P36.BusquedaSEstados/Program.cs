using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P36.BusquedaSEstados
{
    class Program
    {
        class BusquedaSecuencial
        {
            string[] vector = new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };
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
                for (int c = 0; c <= 31; c++)
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
                key = Console.ReadLine();
                while (i <= n & found == false)
                {
                    if (key == vector[i])
                    {
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (found == false)
                {
                    Console.WriteLine("El elemento {0} no está en el arreglo", key);
                }
                else
                {
                    Console.WriteLine("El elemento {0} está en la posición {1}", key, i+1);
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
                Console.WriteLine("MENU BUSQUEDA SECUENCIAL" + '\n');
                Console.WriteLine("1. Inicializar arreglo");
                Console.WriteLine("2. Desplegar y Buscar un elemento");
                Console.WriteLine("3. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            b.Inicializar();
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
                            b.Imprimir();
                            Console.Write('\n');
                            b.Buscar();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
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
