using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5._1.Recursividad
{
    class Program
    {
        public class Recursividad
        {
            public void imprimir(int x)
            {
                if (x > 0)
                {
                    Console.Write(x);
                    imprimir(x - 1);
                }

            }
        }
        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.imprimir(5);
            Console.ReadKey();
        }
    }
}
