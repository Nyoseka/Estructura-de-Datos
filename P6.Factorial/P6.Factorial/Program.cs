using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6.Factorial
{
    class Program
    {
        public class Fact
        {
            public int Factorial(int n)
            {
                if (n > 0)
                {
                    return n * Factorial(n - 1);
                }
                else 
                {
                    return 1;
                }
            }
        static void Main(string[] args)
        {
            Fact f = new Fact();
            int numero;
            int opcion;
            Console.WriteLine("MENU" +'\n');
            Console.WriteLine("1. Calcular");
            Console.WriteLine("2. Salir");
            Console.Write('\n'+"Selecciona una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: opcion = 1;
                    {
                        Console.Clear();
                        Console.Write("Ingrese un numero: ");
                        numero = f.Factorial(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Factorial: {0}",numero);
                        break;
                    }
                case 2: opcion = 2;
                    {
                        Console.Clear();
                        break;
                    }
            }
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
            }
        }
    }
}
