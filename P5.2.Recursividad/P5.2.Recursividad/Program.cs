using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5._2.Recursividad
{
    class Program
    {
        public class TrianguloRecursivo
        {
            public int Triangulo(int Cantidad, int i)
            {
                if (Cantidad == 1 || Cantidad == 0 || i == 1 || i == 0)
                {
                    return 1;
                }
                else
                {
                    return Triangulo(Cantidad - 1, i) + Triangulo(Cantidad - 1, i - 1);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        TrianguloRecursivo triangulo = new TrianguloRecursivo();
        int i = 0;
        int Count = 0;
        int Cantidad = 0;
        int Columna = 0;
        int Fila = 0;

        Console.Write("Cuantas Filas: ");
        Cantidad = int.Parse(Console.ReadLine());

        int[,] MAT = new int[Cantidad + 1, Cantidad + 1];

        for (int i = 0; i <= 6; i++)
        {
            for (int ii = 0; ii <= i; ii++)
                Console.WriteLine(triangulo.Triangulo(i, ii) + " ");
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
