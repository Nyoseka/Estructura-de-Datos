using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5._3.Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            string result = null;
            Program ob = new Program();

            Console.Write("Indica un número : ");
            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch { }

            result = ob.getBinario(numero);

            Console.WriteLine();
            Console.WriteLine("El valor binario de " + numero + " es " + result);
            Console.WriteLine();
            Console.ReadKey();
        }

        private string getBinario(int numero)
        {
            string resto = "";
            string binario = "";

            while ((numero >= 2))
            {
                resto = resto + (numero % 2).ToString();
                numero = numero / 2;
            }
            resto = resto + numero.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;
        }
    }
}
