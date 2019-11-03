using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6.SerieFibonacci
{
    class Program
    {
            static int Fibonacci(int n)
            {
                if (n==0||n==1)
                        {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());
            for(int i=0; i<=n-1; i++)
            {
                Console.WriteLine("El Fibonacci de {0} es {1}", (i + 1), Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
