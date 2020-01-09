using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13.SumarVectores
{
    class Program
    {
        public static int[] vector1;
        public static int[] vector2;
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
                    return(vector1[n] + vector2[n]) + SumarVectores(vector1, vector2, n - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            SumaVector sv1 = new SumaVector();
            int opcion;
            int n;
            void menu()
            {
                Console.WriteLine("MENU SUMA DE VECTORES" + '\n');
                Console.WriteLine("1. Generar vectores");
                Console.WriteLine("2. Sumar Vectores");
                Console.WriteLine("3. Imprimir Vectores");
                Console.WriteLine("4. Salir del Programa" + '\n');
                Console.Write("Selecciona una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            Console.Write("Indique el tamaño de ambos vectores: ");
                            n = int.Parse(Console.ReadLine());
                            vector1 = new int[n];
                            vector2 = new int[n];
                            for (int c = 0; c <= n - 1; c++)
                            {
                                int num;
                                num = random.Next(0, n);
                                vector1[c] = num;
                                vector1[c] = num;
                            }
                            Console.WriteLine("Vector generado con exito");
                            menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            break;
                        }
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
