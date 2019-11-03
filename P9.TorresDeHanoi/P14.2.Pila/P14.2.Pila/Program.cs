using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14._2.Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int tope;
            Console.Write("Ingrese el limite de valores a la pila: ");
            tope = int.Parse(Console.ReadLine());
            Console.Clear();
            for(int c=0; c<=tope-1;c++)
            {
                Console.Write("Ingrese un valor a la pila: ");
                stack.Push(int.Parse(Console.ReadLine()));
            }
            Console.Clear();
            int pop = stack.Pop();
            Console.WriteLine("--- Contenido de la pila ---");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.Write('\n');
            Console.WriteLine("--- Ultimo valor de la pila ---");
            Console.WriteLine(pop);
            Console.ReadKey();
        }
    }
}
