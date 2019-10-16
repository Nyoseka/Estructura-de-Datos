using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.PruebaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cola1 = new Queue<int>();

            int DatoI;
            int DatoP;
            int DatoC;

            Console.Write("Ingrese un priner dato para agregar: ");
            DatoI = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un segundo dato: ");
            DatoP = int.Parse(Console.ReadLine());
            Console.Write("Inserte un tercer dato: ");
            DatoC = int.Parse(Console.ReadLine());
            cola1.Enqueue(DatoI);
            cola1.Enqueue(DatoP);
            cola1.Enqueue(DatoC);
            Console.Clear();
            Console.WriteLine("Cola"+'\n');
            Console.WriteLine("Numero de elementos: ",cola1.Count());
            Console.WriteLine("Elementos dentro de la cola");
            foreach(int dato in cola1)
            {
                Console.Write(dato + " ");
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
