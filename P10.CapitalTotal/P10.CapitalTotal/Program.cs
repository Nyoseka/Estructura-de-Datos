using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.CapitalTotal
{
    class Program
    {
        public class CapitalTotal
        {
            public float CTotal(float m, float x, int n)
            {
                if(n==0)
                {
                    return m;
                }
                else
                {
                    return CTotal(m, x, n - 1) + (CTotal(m, x, n - 1) * x);
                }
            }
        }
        static void Main(string[] args)
        {
            CapitalTotal capital = new CapitalTotal();
            float m;
            float x;
            int n;
            int opcion;
            Console.WriteLine("MENU CAPITAL TOTAL");
            Console.WriteLine("   ------   " +'\n');
            Console.WriteLine("1. Calcular y Desplegar Capital Total");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: opcion = 1;
                    {
                        Console.Clear();
                        Console.Write("Introduzca un monto: ");
                        m = float.Parse(Console.ReadLine());
                        Console.Write("Introduzca el interes anual: ");
                        x = float.Parse(Console.ReadLine());
                        Console.Write("Introduzca el numero de años a calcular: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("Capital Total: {0}",capital.CTotal(m,x,n));
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
