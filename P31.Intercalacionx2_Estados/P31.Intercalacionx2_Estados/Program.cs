using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31.Intercalacionx2_Estados
{
    class Program
    {
        class Intercalacion
        {
            string[] vectorX = new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };
            public void Inicializar()
            {
                Random random = new Random();
                for (int c = 0; c <= 31; c++)
                {
                    string temp = vectorX[c];
                    int i = random.Next(0, 31);
                    vectorX[c] = vectorX[i];
                    vectorX[i] = temp;
                }
            }
            public void Imprimir()
            {
                for (int c = 0; c <= 31; c++)
                {
                    Console.WriteLine((c + 1) + ". {0} ", vectorX[c]);
                }
            }

            public void Intercalar()
            {
                string[] aux = new string[32];
                int p = 1;
                int l1, k, l2, m1, m2, j, i, y;
                int n = vectorX.Length - 1;
                while (p < n)
                {
                    l1 = 0;
                    k = 0;
                    while (l1 + p <= n)
                    {
                        l2 = l1 + p;
                        m1 = l2 - 1;
                        if ((l2 + p) - 1 <= n)
                        { m2 = (l2 + p) - 1; }
                        else
                        {
                            m2 = n - 1;
                        }
                        i = l1;
                        j = l2;
                        while (i <= m1 && j <= m2)
                        {
                            if (string.Compare(vectorX[i],vectorX[j]) <1)
                            {
                                aux[k] = vectorX[i];
                                i++;
                                k++;
                            }
                            else
                            {
                                aux[k] = vectorX[j];
                                j++;
                                k++;
                            }
                        }
                        if (i > m1)
                        {
                            for (y = j; y <= m2; y++)
                            {
                                aux[k] = vectorX[y];
                                k++;
                            }
                            l1 = m2 + 1;
                        }
                        else
                        {
                            for (y = i; y <= m1; y++)
                            {
                                aux[k] = vectorX[y];
                                k++;
                            }
                            l1 = m2 + 1;
                        }
                    }

                    for (i = l1; k < n; i++)
                    {
                        aux[k] = vectorX[i];
                        k++;
                    }
                    for (i = 0; i < n; i++)
                    {
                        vectorX[i] = aux[i];
                    }
                    p = p * 2;

                }
            }
            static void Main(string[] args)
            {
                Intercalacion inter = new Intercalacion();
                int opcion;
                Menu();
                void Menu()
                {
                    Console.WriteLine("MENU DE INTERCALACION CUADRATICA" + '\n');
                    Console.WriteLine("1. Generar vector");
                    Console.WriteLine("2. Desplegar vector");
                    Console.WriteLine("3. Intercalar vectores");
                    Console.WriteLine("4. Salir del programa");
                    Console.Write('\n' + "Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            opcion = 1;
                            {
                                Console.Clear();
                                inter.Inicializar();
                                Console.WriteLine("Arreglo generado con éxito");
                                Console.ReadKey();
                                Console.Clear();
                                Menu();
                                break;
                            }
                        case 2:
                            opcion = 2;
                            {
                                Console.Clear();
                                Console.WriteLine("ARREGLO" + '\n');
                                inter.Imprimir();
                                Console.ReadKey();
                                Console.Clear();
                                Menu();
                                break;
                            }
                        case 3:
                            opcion = 3;
                            {
                                Console.Clear();
                                inter.Intercalar();
                                Console.WriteLine("Vector intercalado con éxito");
                                Console.ReadKey();
                                Console.Clear();
                                Menu();
                                break;
                            }
                        case 4:
                            opcion = 4;
                            {
                                Console.Clear();
                                Console.WriteLine("Pulse cualquier tecla para salir");
                                Console.ReadKey();
                                break;
                            }
                    }
                }
            }
        }
    }
}
