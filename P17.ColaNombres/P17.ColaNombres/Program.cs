using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17.ColaNombres
{
    class Program
    {
        public class Colas
        {
            public int max;
            public int frente;
            public int final;
            public int apuntador;
            public string[] cola;

            public Colas()
            { }
            public Colas(int max)
            {
                this.max = max;
                frente = -1;
                final = -1;
                string[] cola = new string[max];
                this.cola = cola;
            }
            public void Push(string elemento)
            {
                if (frente == 0 & max == -1)
                {
                    Console.WriteLine("La Cola esta llena");
                }
                else
                {
                    if (frente == -1)
                    {
                        frente = 0;
                        final = 0;
                    }
                    else
                    {
                        final = final + 1;
                    }
                    cola[final] = elemento;
                }
            }
            public void Pop()
            {
                if (frente != -1)
                {
                    Console.WriteLine("Elemento: {0} sera eliminado", cola[frente]);
                    if (frente == final)
                    {
                        frente = -1;
                        final = -1;
                    }
                }
                else
                {
                    Console.WriteLine("La cola esta vacia");
                }
            }
            public void Recorrido()
            {
                if (frente != -1)
                {
                    apuntador = frente;
                    while (apuntador <= final)
                    {
                        Console.WriteLine("Elemento: {0}, posicion: {1}", cola[apuntador], apuntador);
                        apuntador = apuntador + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Cola vacia");
                }
            }
            public void Busqueda(string elemento)
            {
                if (frente != -1)
                {
                    apuntador = frente;
                    while (apuntador <= final)
                    {
                        if (elemento == cola[apuntador])
                        {
                           Console.WriteLine("Dato {0} localizado en la posicion {1}", elemento, apuntador);
                            apuntador = apuntador + 1;
                        }
                        else
                        {
                            apuntador = apuntador + 1;
                        }
                    }
                    Console.WriteLine("Dato {0} no encontrado en la cola", elemento);
                }
                else
                {
                    Console.WriteLine("Cola vacia");
                }
            }
            ~Colas()
            {
                Console.WriteLine("Cola eliminada");
            }
        }
        static void Main(string[] args)
        {
            Colas cola = new Colas();
            int max;
            int opcion;
            string e;
            string ebusqueda;
            Menu();
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();

            void Menu()
            {
                Console.WriteLine("MENU COLAS" + '\n');
                Console.WriteLine("1. Crear Cola");
                Console.WriteLine("2. Insertar Datos");
                Console.WriteLine("3. Eliminar Datos");
                Console.WriteLine("4. Recorrer la Cola");
                Console.WriteLine("5. Buscar elementos");
                Console.WriteLine("6. Salir");
                Console.Write('\n' + "Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            Console.Write("Ingrese el tamaño de la cola: ");
                            max = int.Parse(Console.ReadLine());
                            cola = new Colas(max);
                            Console.WriteLine("Cola creada exitosamente" + '\n');
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.Write("Ingrese un dato para insertar en la pila: ");
                            e = Console.ReadLine();
                            cola.Push(e);
                            Console.WriteLine("Elemento agregado a la cola" + '\n');
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            cola.Pop();
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            cola.Recorrido();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 5:
                        opcion = 5;
                        {
                            Console.Clear();
                            Console.Write("Ingrese un valor a buscar: ");
                            ebusqueda = Console.ReadLine();
                            cola.Busqueda(ebusqueda);
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 6:
                        opcion = 6;
                        {
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
