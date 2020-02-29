using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19.ArbolNumeros
{
    class Program
    {
        public class Arbol
        {
            float info;
            Arbol izquierdo;
            Arbol derecho;

            public Arbol()
            {
                info = 0;
                izquierdo = null;
                derecho = null;
            }
            public Arbol raiz = null;

            public void Insertar(float dato)
            {
                int bandera = 0;
                Arbol hoja = new Arbol();
                hoja.info = dato;
                if(raiz==null)
                {
                    raiz=hoja;
                }
                else
                {
                    Arbol temp = raiz;
                    while(bandera!=1)
                    {
                        if(hoja.info<raiz.info)
                        {
                            if(temp.izquierdo==null)
                            {
                                temp.izquierdo = hoja;
                                bandera = 1;
                            }
                            else
                            {
                                temp = temp.izquierdo;
                            }
                        }
                        else
                        {
                            if(temp.derecho==null)
                            {
                                temp.derecho = hoja;
                                bandera = 1;
                            }
                            else
                            {
                                temp = temp.derecho;
                            }
                        }
                    }
                }
            }

            public void Preorden(Arbol temp)
            {
                if(temp!=null)
                {
                    Console.Write("{0} ",temp.info);
                    if(temp.izquierdo != null)
                    {
                        Preorden(temp.izquierdo);
                    }
                    if(temp.derecho!=null)
                    {
                        Preorden(temp.derecho);
                    }
                }
                else
                {
                    Console.WriteLine("Árbol binario vacío");
                }
            }

            public void Inorden(Arbol temp)
            {
                if(temp!=null)
                {
                    if (temp.izquierdo != null)
                    {
                        Inorden(temp.izquierdo);
                    }
                    Console.Write("{0} ", temp.info);
                    if(temp.derecho!=null)
                    {
                        Inorden(temp.derecho);
                    }
                }
                else
                {
                    Console.WriteLine("Árbol binario vacío");
                }
            }

            public void Posorden(Arbol temp)
            {
                if (temp != null)
                {
                    if (temp.izquierdo != null)
                    {
                        Posorden(temp.izquierdo);
                    }
                    if(temp.derecho!=null)
                    {
                        Posorden(temp.derecho);
                    }
                    Console.Write("{0} ", temp.info);
                }
                else
                {
                    Console.WriteLine("Árbol binario vacío");
                }
            }

            public void BusquedaRecursiva(float key, Arbol temp)
            {
                if(temp==null)
                {
                    Console.WriteLine("El nodo {0} no está en el árbol binario",key);
                }
                else
                {
                    if(key==temp.info)
                    {
                        Console.WriteLine("El nodo {0} si está en el árbol binario", key);
                    }
                    else
                    {
                        if(key<temp.info)
                        {
                            BusquedaRecursiva(key, temp.izquierdo);
                        }
                        else
                        {
                            BusquedaRecursiva(key, temp.derecho);
                        }
                    }
                }
            }

            public void BusquedaIterativa(float key, Arbol temp)
            {
                bool encontrado = false;
                do
                {
                    if(key==temp.info)
                    {
                        encontrado = true;
                    }
                    else
                    {
                        if(key <temp.info)
                        {
                            temp = temp.izquierdo;
                        }
                        else
                        {
                            temp = temp.derecho;
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("El nodo {0} no está en el árbol binario", key);
                    }
                    else
                    {
                        Console.WriteLine("El nodo {0} está en el arbol binario", key);
                    }
                }
                while ((temp != null) & (encontrado = false));
            }

            public void Eliminar()
            {
                Arbol p, q, v, s, t;
                bool encontrado = false;
                float x;
                p = raiz;
                q = null;
                if (p != null)
                {
                    Console.Write("Ingrese el nodo a eliminar: ");
                    x = float.Parse(Console.ReadLine());
                    while (p != null & encontrado == false)
                    {
                        if (p.info == x)
                        {
                            encontrado = true;
                            Console.WriteLine("El nodo {0} será eliminado", p.info);
                        }
                        else
                        {
                            q = p;
                            if (x < p.info)
                            {
                                p = p.izquierdo;
                            }
                            else
                            {
                                p = p.derecho;
                            }
                        }
                    }
                    if (encontrado == true)
                    {
                        if (p.izquierdo == null)
                        {
                            v = p.derecho;
                        }
                        else
                        { 
                            if(p.derecho==null)
                            {
                                v=p.izquierdo;
                            }
                            else
                            {
                                t = p;
                                v = p.derecho;
                                s = v.izquierdo;
                                do
                                {
                                    t = v;
                                    v = s;
                                    s = v.izquierdo;
                                }
                                while (s != null);
                                if(t!=p)
                                {
                                    t.izquierdo = v.derecho;
                                    v.derecho = p.derecho;
                                }
                                v.izquierdo = p.izquierdo;
                            }
                        }
                        if (q == null)
                        {
                            raiz = v;
                        }
                        else
                        {
                            if (q == null)
                            {
                                q.derecho = v;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("El nodo {0} no está en el árbol binario", x);
                    }
                }
                else
                {
                    Console.WriteLine("El árbol binario está vacío");
                }
            }
            ~Arbol() 
            { }
        }
        static void Main(string[] args)
        {
            int opcion;
            float dat;
            float key;
            Arbol arbol=new Arbol();
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU ARBOLES BINARIOS" + '\n');
                Console.WriteLine("1. Insertar nodos");
                Console.WriteLine("2. Eliminar nodos");
                Console.WriteLine("3. Recorrido Preorden");
                Console.WriteLine("4. Recorrido Inorden");
                Console.WriteLine("5. Recorrido Posorden");
                Console.WriteLine("6. Busqueda Recursiva");
                Console.WriteLine("7. Busqueda Iterativa");
                Console.WriteLine("8. Salir");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: opcion = 1;
                        {
                            Console.Clear();
                            Console.WriteLine("CREAR NODO"+'\n');
                            Console.Write("Ingrese un número a agregar: ");
                            dat = float.Parse(Console.ReadLine());
                            arbol.Insertar(dat);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2: opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("ELIMINAR NODO" + '\n');
                            arbol.Eliminar();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3: opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("RECORRIDO EN PREORDEN" + '\n');
                            arbol.Preorden(arbol.raiz);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4: opcion = 4;
                        {
                            Console.Clear();
                            Console.WriteLine("RECORRIDO EN INORDEN" + '\n');
                            arbol.Inorden(arbol.raiz);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 5: opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("RECORRIDO EN POSORDEN" + '\n');
                            arbol.Posorden(arbol.raiz);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 6: opcion = 6;
                        {
                            Console.Clear();
                            Console.WriteLine("BÚSQUEDA RECURSIVA" + '\n');
                            Console.Write("Ingrese el elemento a buscar: ");
                            key = float.Parse(Console.ReadLine());
                            arbol.BusquedaRecursiva(key, arbol.raiz);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 7: opcion=7;
                        {
                            Console.Clear();
                            Console.WriteLine("BÚSQUEDA ITERATIVA" + '\n');
                            Console.Write("Ingrese el elemento a buscar: ");
                            key = float.Parse(Console.ReadLine());
                            arbol.BusquedaIterativa(key, arbol.raiz);
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 8: opcion = 8;
                        {
                            Console.Clear();
                            Console.WriteLine("Pulse cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción no válida");
                            break;
                        }
                }
            }
        }
    }
}
