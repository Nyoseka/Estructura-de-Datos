using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.SumaDeVectores
{
    class Program
    {
        public static int[] vector;
        public class Vector
        {
            Random aleatorio = new Random();
            public void Generar(int n)
            {
                vector = new int [n];
                for(int c=0; c <=n-1;c++)
                {
                    vector[c] = aleatorio.Next(0, 50);
                }
            }
            public void Imprimir(int n)
            {
                for (int c = 0; c <= n - 1; c++)
                {
                    Console.Write(vector[c] + " ");
                }
            }
            public int SumaVector(int[]vector, int n)
            {
                if(n==0)
                {
                    return vector[n];
                }
                else
                {
                    return vector[n] + SumaVector(vector, n - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            Vector v1 = new Vector();
            int op;
            int n;
            int promedio;
            Console.WriteLine("MENU SUMA ELEMENTOS DE UN VECTOR");
            Console.WriteLine("   -----   ");
            Console.WriteLine("1. Generar vector");
            Console.WriteLine("2. Sumar elementos");
            Console.WriteLine("3. Desplegar elementos, suma y promedio");
            Console.WriteLine("4. Salir");
            Console.Write('\n' + "Seleccione una opcion: ");
            op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1: op = 1;
                    {
                        Console.Clear();
                        Console.WriteLine("Indique el tamaño del vector");
                        n = int.Parse(Console.ReadLine());
                        v1.Generar(n);
                        Console.WriteLine("Vector generado con exito");
                        break;
                    }
                case 2: op = 2;
                    {
                        Console.Clear();
                        Console.WriteLine("Indique el tamaño del vector");
                        n = int.Parse(Console.ReadLine());
                        v1.Generar(n);
                        Console.WriteLine("Suma realizada con exito");
                        Console.WriteLine("Suma de elementos: ");
                        Console.WriteLine(v1.SumaVector(vector,n-1));
                        goto case 3;
                    }
                case 3: op = 3;
                    {
                        Console.Write("Confirme el tamaño del vector para imprimir: ");
                        n = int.Parse(Console.ReadLine());
                        v1.Imprimir(n);
                        break;
                    }
                case 4: op = 4;
                    {
                        Console.Clear();
                        break;
                    }
            }
            Console.WriteLine('\n'+"Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
