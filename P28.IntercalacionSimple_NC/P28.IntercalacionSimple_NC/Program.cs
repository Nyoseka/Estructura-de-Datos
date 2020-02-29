using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P28.IntercalacionSimple_NC
{
    class Program
    {
        class IntercalacionSim
        {
            int[] vectorA = new int[25];
            int[] vectorB = new int[25];
            int[] vectorC = new int[50];

            public void Generar()
            {
                Random random = new Random();
                for (int c = 0; c <= 24; c++)
                {
                    vectorA[c] = random.Next(18210000, 18210100);
                    vectorB[c] = random.Next(18210000, 18210100);
                }
            }

            public void ImprimirVectores()
            {
                Console.WriteLine("VECTOR A");
                for (int c = 0; c <= 24; c++)
                {
                    Console.WriteLine("{0}. {1}", c + 1, vectorA[c]);
                }
                Console.WriteLine('\n' + "VECTOR B");
                for (int i = 0; i <= 24; i++)
                {
                    Console.WriteLine("{0}. {1}", i + 1, vectorB[i]);
                }
            }

            public void OrdenarVectorA()
            {
                int temp;
                for (int c = 0; c <= 24; c++)
                {
                    for (int i = 0; i <= 23; i++)
                    {
                        if (vectorA[i] > vectorA[i + 1])
                        {
                            temp = vectorA[i];
                            vectorA[i] = vectorA[i + 1];
                            vectorA[i + 1] = temp;
                        }
                    }
                }
            }

            public void OrdenarVectorB()
            {
                int temp;
                for (int c = 0; c <= 24; c++)
                {
                    for (int i = 0; i <= 23; i++)
                    {
                        if (vectorB[i] > vectorB[i + 1])
                        {
                            temp = vectorB[i];
                            vectorB[i] = vectorB[i + 1];
                            vectorB[i + 1] = temp;
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
                    if (vectorA[i] <= vectorB[j])
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
                    for (int x = i; x <= N; x++)
                    {
                        vectorC[k] = vectorA[x];
                        k++;
                    }
                }
                else
                {
                    for (int x = i; x <= M; x++)
                    {
                        vectorC[k] = vectorB[x];
                        k++;
                    }
                }
            }
            public void VectorC()
            {
                for (int c = 0; c <= 49; c++)
                {
                    Console.WriteLine("{0}. {1}",c+1,vectorC[c]);
                }
            }
        }
        static void Main(string[] args)
        {
            IntercalacionSim sim = new IntercalacionSim();
            int opcion;
            Menu();
            
            void Menu()
            {
                Console.WriteLine("MENÚ INTERCALACIÓN SIMPLE"+'\n');
                Console.WriteLine("1. Generar vectores A y B");
                Console.WriteLine("2. Desplegar vectores A y B");
                Console.WriteLine("3. Ordenar A y B");
                Console.WriteLine("4. Intercalar vector C");
                Console.WriteLine("5. Desplegar vector C");
                Console.WriteLine("6. Salir del programa");
                Console.Write('\n'+"Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            Console.WriteLine("GENERAR ARREGLOS");
                            sim.Generar();
                            Console.WriteLine('\n' + "Los vectores A y B han sido generados correctamente");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("Vectores A y B"+'\n');
                            sim.ImprimirVectores();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("ORDENAR VECTORES");
                            sim.OrdenarVectorA();
                            sim.OrdenarVectorB();
                            Console.WriteLine('\n' + "Arreglo ordenado");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4: opcion = 4;
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
                    case 5: opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("Vector C" + '\n');
                            sim.VectorC();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 6: opcion = 6;
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
