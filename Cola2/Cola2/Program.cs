using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cola = new Queue<string>();

            cola.Enqueue("Perro");
            cola.Enqueue("Gato");
            cola.Enqueue("Loro");
            cola.Enqueue("Tigre");
            cola.Enqueue("Leon");
            cola.Enqueue("Lobo");
            cola.Enqueue("Zorro");
            cola.Enqueue("Conejo");

            Console.WriteLine("Pila de animales"+'\n');
            Console.WriteLine("Elementos dentro de la cola: ");
            foreach(var obj in cola)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine('\n'+"   -----   "+'\n');
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Elementos totales que se encuentran en la cola: " + cola.Count);

                Console.WriteLine("Elemento retirado de la cola: " + cola.Dequeue());
                Console.WriteLine("el proximo elemento que queda en la cola es: " + cola.Peek());
                Console.WriteLine("");
                Console.WriteLine("");
            }

            Console.WriteLine("Elementos totales que se encuentran en la cola: " + cola.Count);
            Console.WriteLine('\n' + "Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
