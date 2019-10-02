using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3.MemoriaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack numeros = new Stack();
            numeros.Push("Uno");
            numeros.Push("Dos");
            numeros.Push("Tres");
            numeros.Push("Cuatro");
            numeros.Push("Cinco");
            IEnumerator enumerator = numeros.GetEnumerator();
            foreach (string numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
