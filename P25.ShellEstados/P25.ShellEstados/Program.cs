using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25.ShellEstados
{
    class Program
    {
        class ShellSort
        {
            string[] vector = new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };

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

            public void Ordenamiento()
            {
                int n=vector.Length-1;
                int[] incremento = new int[] { 1, 2, 3, 5, 7, 11, 13 };
                for (int m=incremento.Length-1; m>=0; m--)
            {
                int h = incremento[m];

                    for (int j = h; j <= n; j++)
                    {
                        int i = j - h;
                        string k = vector[j];

                        while (i >= 0 && string.Compare(k, vector[i])< 1)
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
                            shell.Inicializar();
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
