using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19.ListaNumerosFlotantes
{
    class Program
    {
        public class Nodo
        {
            public float elemento;
            public int siguiente;

            public Nodo()
            { }
            public Nodo(float e, int s)
            {
                elemento = e;
                siguiente = s;
            }

            ~Nodo()
            {
                Console.WriteLine("Memoria Objeto Nodo liberada");
            }
        }
        class Lista
        {
            public Nodo[] lista;
            public int ini;
            public int disp;
            public int pos;
            public int aux;
            public int max;
            public int tamano = 0;
            public float num;
            public char otra;

            public Lista()
            {

            }
            public void Inicializar(int tamano)
            {
                int c = 0;
                max = tamano;
                Nodo[] lista = new Nodo[max];
                this.lista = lista;
                ini = 0;
                for (int i = 0; i <= max-1 - 1; i++)
                {
                    lista[c] = new Nodo(0, i + 1);
                }
                lista[max - 1] = new Nodo(0, c + -1);
            }
                public void Insertar()
            {
                do
                {
                    int temp;
                    if (tamano == max)
                    {
                        Console.WriteLine("La lista esta llena");
                    }
                    else
                    {
                        Console.Write("Ingrese un numero para agregar: ");
                        num = float.Parse(Console.ReadLine());
                        temp = lista[disp].siguiente;
                        LugarInsertar(num);
                        if (pos == ini)
                        {
                            lista[disp].siguiente = ini;
                            ini = disp;
                        }
                        else
                        {
                            lista[disp].siguiente = lista[aux].siguiente;
                            lista[aux].siguiente = disp;
                        }
                        disp = temp;
                    }
                    tamano = tamano + 1;
                    Console.WriteLine('\n');
                    Console.WriteLine("¿Desea insertar otro elemento?");
                    Console.WriteLine("s. Si");
                    Console.WriteLine("n. No");
                    Console.Write("Seleccione una opcion: ");
                    otra = char.Parse(Console.ReadLine());
                }
                while (otra == 's');
            }
            public void LugarInsertar(float elemento)
            {
                int enc = 0;
                pos = ini;
                aux = 0;
                do
                {
                    if ((lista[pos].elemento) > (num))
                    {
                        enc = 1;
                    }
                    else
                    {
                        aux = pos;
                        pos = lista[pos].siguiente;
                    }
                }
                while (pos != -1 & enc != 1);
            }
            public int LugarEliminar(float dato)
            {
                int enc = 0;
                pos = ini;
                aux = -1;
                do
                {
                    if (lista[pos].elemento == dato)
                    {
                        enc = 1;
                    }
                    else
                    {
                        aux = pos;
                        pos = lista[pos].siguiente;
                    }
                }
                while (pos != -1 & enc != 1);
                if (enc == 0)
                {
                    Console.WriteLine("El elemento {0} no está en la lista", dato);
                }
                else
                {
                    Console.WriteLine("El elemento {0} se eliminará de la lista", dato);
                }
                return enc;
            }
            public void Eliminar()
            {
                int enc;
                int temp;
                do
                {
                    if (tamano == 0)
                    {
                        Console.WriteLine("La lista esta vacía");
                    }
                    else
                    {
                        Console.WriteLine("Indique el numero a eliminar: ");
                        num = float.Parse(Console.ReadLine());
                        enc = LugarEliminar(num);
                        if (enc == 1)
                        {
                            if (aux != -1)
                            {
                                lista[aux].siguiente = lista[pos].siguiente;
                            }
                            else
                            {
                                ini = lista[pos].siguiente;
                            }
                            lista[pos].elemento = 0;
                            lista[pos].siguiente = -1;
                            temp = disp;
                            do
                            {
                                if (lista[temp].siguiente != -1)
                                {
                                    temp = lista[temp].siguiente;
                                }
                                else
                                {
                                    lista[temp].siguiente = pos;
                                }
                            }
                            while (temp != -1);
                        }
                        tamano = tamano - 1;
                    }
                    Console.WriteLine('\n');
                    Console.WriteLine("¿Desea eliminar otro elemento?");
                    Console.WriteLine("s. Si");
                    Console.WriteLine("n. No");
                    Console.Write("Seleccione una opcion: ");
                    otra = char.Parse(Console.ReadLine());
                }
                while (otra == 's');
            }
            public void DesplegarContar()
            {
                int contador = 0;
                if (tamano == 0)
                {
                    Console.WriteLine("Lista vacía");
                }
                else
                {
                    pos = ini;
                    do
                    {
                        Console.WriteLine("Elemento: {0}, posición: {1}", lista[pos].elemento, pos);
                        contador = contador + 1;
                    }
                    while ((pos != -1) && (lista[pos].elemento != 0));
                }
                Console.WriteLine("Total de elementos: {0}", contador);
                Console.WriteLine('\n');
            }
            public void Buscar()
            {
                int enc = 0;
                do
                {
                    if (tamano == 0)
                    {
                        Console.WriteLine("Lista vacía");
                    }
                    else
                    {
                        Console.Write("Ingrese un valor a buscar: ");
                        num = float.Parse(Console.ReadLine());
                        pos = ini;
                        while (pos != -1 & enc != 1)
                        {
                            if (lista[pos].elemento == num)
                            {
                                enc = 1;
                            }
                            else
                            {
                                pos = lista[pos].siguiente;
                            }
                        }
                        if (enc == 0)
                        {
                            Console.WriteLine("El elemento {0} no está en la lista", num);
                        }
                        else
                        {
                            Console.WriteLine("El elemento {0} está en la posición {1}", num, pos);
                        }
                    }
                    Console.WriteLine('\n');
                    Console.WriteLine("¿Desea buscar otro elemento?");
                    Console.WriteLine("s. Si");
                    Console.WriteLine("n. No");
                    Console.Write("Seleccione una opcion: ");
                    otra = char.Parse(Console.ReadLine());
                }
                while (otra == 's');
            }

            ~Lista()
            {
                Console.WriteLine("Memoria liberada");
            }
        }
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            int opcion;
            int tam;
            Menu();
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadKey();

            void Menu()
            {
                Console.WriteLine("MENU LISTA DE ELEMENTO");
                Console.WriteLine("1. Crear Lista");
                Console.WriteLine("2. Insertar Elemento");
                Console.WriteLine("3. Eliminar Elemento");
                Console.WriteLine("4. Recorrer Lista");
                Console.WriteLine("5. Buscar un Elemento");
                Console.WriteLine("6. Salir del Programa");
                Console.Write('\n' + "Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            Console.WriteLine("CREAR LISTA" + '\n');
                            Console.Write("Indique el tamaño de la lista: ");
                            tam = int.Parse(Console.ReadLine());
                            lista.Inicializar(tam);
                            Console.WriteLine('\n' + "Lista creada");
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("AGREGAR ELEMENTOS" + '\n');
                            lista.Insertar();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("ELIMINAR ELEMENTOS" + '\n');
                            lista.Eliminar();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            Console.WriteLine("ELEMENTOS DE LA LISTA" + '\n');
                            lista.DesplegarContar();
                            Console.WriteLine('\n');
                            Menu();
                            break;
                        }
                    case 5:
                        opcion = 5;
                        {
                            Console.Clear();
                            Console.WriteLine("BUSCAR ELEMENTOS" + '\n');
                            lista.Buscar();
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
