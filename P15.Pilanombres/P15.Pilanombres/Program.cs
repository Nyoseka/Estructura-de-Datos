using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15.Pilanombres
{
    class Program
    {
        public class Pilas
        {
            public int max;
            public int top;
            public int apuntador;
            public string[] pila;

            public Pilas()
            { }
            public Pilas(int max)
            {
                this.max = max;
                top = -1;
                string[] pila = new string[max];
                this.pila = pila;
            }
            public void Push(string elemento)
            {
                if (top != max - 1)
                {
                    top = top + 1;
                    pila[top] = elemento;
                }
                else
                {
                    Console.WriteLine("La pila esta llena");
                }
            }
            public void Pop()
            {
                if (top != -1)
                {
                    Console.WriteLine("Elemento eliminado: " + pila[top]);
                    pila[top] = "";
                    top = top - 1;
                }
                else
                {
                    Console.WriteLine("La pila esta vacia");
                }
            }
            public void Recorrido()
            {
                if (top != -1)
                {
                    apuntador = top;
                    while (apuntador != -1)
                    {
                        Console.WriteLine("Elemento: {0}, posicion: {1}", pila[apuntador], apuntador);
                        apuntador = apuntador - 1;
                    }
                }
                else
                {
                    Console.WriteLine("La pila esta vacia");
                }
            }
            public void Busqueda(string elemento)
            {
                if (top != -1)
                {
                    apuntador = top;
                    while (apuntador != -1)
                    {
                        if (pila[apuntador] == elemento)
                        {
                            Console.WriteLine("Elemento {0} localizado en la posicion {1}", elemento, apuntador);
                            apuntador = apuntador - 1;
                        }
                        else
                        {
                            apuntador = apuntador - 1;
                        }
                    }
                    Console.WriteLine("El elemento {0} no esta en la pila", elemento);
                }
                else
                {
                    Console.WriteLine("La pila esta vacia");
                }
            }
            ~Pilas()
            {
                Console.WriteLine("Pila eliminada");
            }
        }
        static void Main(string[] args)
        {
            int max;
            int opcion;
            string element;
            string ebusqueda;
            Pilas pila = new Pilas();
            Menu();
            Console.Write("Pulsa cualquier tecla para salir ");
            Console.ReadKey();

            void Menu()
            {
                Console.WriteLine("MENU PILA DE NOMBRES" + '\n');
                Console.WriteLine("    -----    ");
                Console.WriteLine("1. Crear Pila");
                Console.WriteLine("2. Insertar elementos");
                Console.WriteLine("3. Eliminar elementos");
                Console.WriteLine("4. Recorrer la pila");
                Console.WriteLine("5. Buscar elementos en la pila");
                Console.WriteLine("6. Salir del programa" + '\n');
                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            Console.Write("Ingrese el tamaño de la pila: ");
                            max = int.Parse(Console.ReadLine());
                            pila = new Pilas(max);
                            Console.WriteLine("Pila creada existosamente"+'\n');
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.Write("Ingrese un dato para agregar a la pila: ");
                            element = Console.ReadLine();
                            pila.Push(element);
                            Console.WriteLine("Elemento agregado a la pila" + '\n');
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            pila.Pop();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            pila.Recorrido();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 5:
                        opcion = 5;
                        {
                            Console.Clear();
                            Console.Write("Indique el elemento a buscar: ");
                            ebusqueda = Console.ReadLine();
                            pila.Busqueda(ebusqueda);
                            Console.Write('\n');
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
