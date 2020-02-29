using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29.IntercalacionSimple_Estados
{
    class Program
    {
        class InterSim
        {
            string[] vectorA = new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia" };
            string[] vectorB = new string[] { "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };
            string[] vectorC = new string[32];

            public void Inicializar()
            {
                Random random = new Random();
                for (int c = 0; c <= 15; c++)
                {
                    string temp = vectorA[c];
                    string aux = vectorB[c];
                    int i = random.Next(0, 15);
                    int r = random.Next(0, 15);
                    vectorA[c] = vectorA[i];
                    vectorB[c] = vectorB[r];
                    vectorA[i] = temp;
                    vectorB[r] = aux;
                }
            }
            public void ImprimirVectores()
            {
                Console.WriteLine("VECTOR A");
                for (int c = 0; c <= 15; c++)
                {
                    Console.WriteLine("{0}. {1}", c + 1, vectorA[c]);
                }
                Console.WriteLine('\n' + "VECTOR B");
                for (int i = 0; i <= 15; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, vectorB[i]);
                }
            }

            public void OrdenarA()
            {
                string temp;
                int n = vectorA.Length - 1;
                for (int k = 1; k <= n - 1; k++)
                {
                    for (int l = 0; l <= n - k; l++)
                    {
                        if (string.Compare(vectorA[l], vectorA[l + 1]) > -1)
                        {
                            temp = vectorA[l];
                            vectorA[l] = vectorA[l + 1];
                            vectorA[l + 1] = temp;
                        }
                    }
                }
            }

            public void OrdenarB()
            {
                string temp;
                int n = vectorB.Length - 1;
                for (int k = 1; k <= n - 1; k++)
                {
                    for (int l = 0; l <= n - k; l++)
                    {
                        if (string.Compare(vectorB[l], vectorB[l + 1]) > -1)
                        {
                            temp = vectorB[l];
                            vectorB[l] = vectorB[l + 1];
                            vectorB[l + 1] = temp;
                        }
                    }
                }
            }
            public void Intercalar()
            {
                int i = 0;
                int j = 0;
                int k = 0;
                int N = vectorA.Length - 1;
                int M = vectorB.Length - 1;
                while (i <= N && j <= M)
                {
                    if (string.Compare(vectorA[i], vectorB[j]) < 0)
                    {
                        vectorC[k] = vectorA[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        vectorC[k] = vectorB[j];
                        j++;
                        k++;
                    }
                }
                if (i > N)
                {
                    for (int x = j; x <= N; x++)
                    {
                        vectorC[k] = vectorB[x];
                        k++;
                    }
                }
                else
                {
                    for (int x = i; x <= M; x++)
                    {
                        vectorC[k] = vectorA[x];
                        k++;
                    }
                }
            }
            public void VectorC()
            {
                    for (int c = 0; c <= 31; c++)
                    {
                        Console.WriteLine("{0}. {1}", c + 1, vectorC[c]);
                    }
            }

        }
        static void Main(string[] args)
        {
            InterSim sim = new InterSim();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENÚ INTERCALACIÓN SIMPLE" + '\n');
                Console.WriteLine("1. Generar vectores A y B");
                Console.WriteLine("2. Desplegar vectores A y B");
                Console.WriteLine("3. Ordenar A y B");
                Console.WriteLine("4. Intercalar vector C");
                Console.WriteLine("5. Desplegar vector C");
                Console.WriteLine("6. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            Console.WriteLine("GENERAR ARREGLOS");
                            sim.Inicializar();
                            Console.WriteLine('\n' + "Los vectores A y B han sido generados correctamente");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("Vectores A y B" + '\n');
                            sim.ImprimirVectores();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("ORDENAR VECTORES");
                            sim.OrdenarA();
                            sim.OrdenarB();
                            Console.WriteLine('\n' + "Arreglo ordenado");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            Console.WriteLine("INTERCALACIÓN VECTOR C");
                            sim.Intercalar();
                            Console.WriteLine('\n' + "Vector intercalado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 5:
                        opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("Vector C" + '\n');
                            sim.VectorC();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 6:
                        opcion = 6;
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
