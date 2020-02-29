using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27.QuickSortEstados
{
    class Program
    {
        class QuickSort
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

            public void Ordenar(int L, int R)
            {
                int i = L;
                int j = R;
                string w;
                string x = vector[(L + R) / 2];
                do
                {
                    while (string.Compare(vector[i], x) <0)
                    {
                        i++;
                    }
                    while (string.Compare(vector[j],x) >0)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        w = vector[i];
                        vector[i] = vector[j];
                        vector[j] = w;
                        i++;
                        j--;
                    }
                }
                while (i < j);
                if (L < j)
                {
                    Ordenar(L, j);
                }
                if (i < R)
                {
                    Ordenar(i, R);
                }
            }
        }
        static void Main(string[] args)
        {
            QuickSort quick = new QuickSort();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU QUICKSORT");
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
                            quick.Inicializar();
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
                            quick.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            quick.Ordenar(0,31);
                            Console.Write("Arreglo ordenado con éxito");
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
