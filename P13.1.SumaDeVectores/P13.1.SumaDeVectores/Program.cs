using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13._1.SumaDeVectores
{
    class Program
    {
        public static int[] vector1;
        public static int[] vector2;
        public static int[] resultado;
        protected static int n;
        public class SumaVector
        {
            public int SumarVectores(int[] vector1, int[] vector2, int n)
            {
                if (n == 0)
                {
                    return vector1[n] + vector2[n];
                }
                else
                {
                    return vector1[n] + vector2[n] + SumarVectores(vector1, vector2, n - 1);
                }
            }
            public void VectorResultado()
            {
                for (int c = 0; c <= n - 1; c++)
                {
                    resultado[c] = vector1[c] + vector2[c];
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            SumaVector sv1 = new SumaVector();
            int opcion;
            menu();
            Console.Write("Presione cualquier tecla para salir ");
            Console.ReadKey();

            void GenerarVectores()
            {
                for (int c = 0; c <= n - 1; c++)
                {
                    int num1;
                    int num2;
                    num1 = random.Next(0, 15);
                    num2 = random.Next(0, 15);
                    vector1[c] = num1;
                    vector2[c] = num2;
                }
            }
            void menu()
            {
                Console.WriteLine("MENU SUMA DE VECTORES" + '\n');
                Console.WriteLine("1. Generar vectores");
                Console.WriteLine("2. Sumar Vectores");
                Console.WriteLine("3. Imprimir Vectores");
                Console.WriteLine("4. Salir del Programa" + '\n');
                Console.Write("Selecciona una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            Console.Write("Indique el tamaño de ambos vectores: ");
                            int n;
                            n = int.Parse(Console.ReadLine());
                            vector1 = new int[n];
                            vector2 = new int[n];
                            resultado = new int[n];
                            GenerarVectores();
                            Console.WriteLine("Vector generado con exito");
                            Console.Write('\n');
                            menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            sv1.SumarVectores(vector1, vector2, n);
                            Console.WriteLine("Suma realizada con exito"+'\n');
                            menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("Confirme el tamaño de los vectores: ");
                            n = int.Parse(Console.ReadLine());
                            GenerarVectores();
                            Console.WriteLine("   ------   ");
                            Console.WriteLine("Vector 1: ");
                            for (int c = 0; c <= n - 1; c++)
                            {
                                Console.Write(vector1[c] + " ");
                            }
                            Console.WriteLine('\n' + "Vector 2: ");
                            for (int c = 0; c <= n - 1; c++)
                            {
                                Console.Write(vector2[c] + " ");
                            }
                            sv1.VectorResultado();
                            Console.WriteLine('\n' + "Vector Resultado: ");
                            for (int c = 0; c <= n - 1; c++)
                            {
                                Console.Write(resultado[c]+ " ");
                            }
                            Console.WriteLine('\n');
                            menu();
                            break;
                        }
                    case 4: opcion = 4;
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
