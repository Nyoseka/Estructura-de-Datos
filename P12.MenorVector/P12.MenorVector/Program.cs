using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.MenorVector
{
    class Program
    {
        public static int[] a;
        public class Arreglo
        {
            Random aleatorio = new Random();
            public void Generar(int n)
            {
                a = new int[n];
                for (int c = 0; c <= n - 1; c++)
                {
                    a[c] = aleatorio.Next(0, 50);
                }
            }
            public void Imprimir(int n)
            {
                for (int c = 0; c <= n - 1; c++)
                {
                    Console.Write(a[c] + " ");
                }
            }
            public int EMenor(int[]a,int n, int menor)
            {
                if(n==0)
                {
                    if (menor > a[0])
                    {
                        return a[0];
                    }
                    else
                    {
                        return menor;
                    }
                }
                else
                {
                    if(menor<a[n])
                    {
                        return EMenor(a, n - 1, menor);
                    }
                    else
                    {
                        menor = a[n];
                        return EMenor(a, n - 1, menor);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Arreglo a1 = new Arreglo();
            int opcion;
            int n;
            Console.WriteLine("MENU NUMERO MENOR");
            Console.WriteLine("   -----   ");
            Console.WriteLine("1. Generar arreglo");
            Console.WriteLine("2. Determinar menor");
            Console.WriteLine("3. Desplegar arreglo y elemento menor");
            Console.Write('\n' + "Seleccione una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: opcion = 1;
                    {
                        Console.Clear();
                        Console.WriteLine("Indique el tamaño del vector");
                        n = int.Parse(Console.ReadLine());
                        a1.Generar(n);
                        a1.Imprimir(n);
                        Console.WriteLine('\n' + "Arreglo generado con exito");
                        break;
                    }
                case 2: opcion = 2;
                    {
                        Console.Clear();
                        Console.WriteLine("Indique el tamaño del arreglo");
                        n = int.Parse(Console.ReadLine());
                        int menor = n;
                        a1.Generar(n);
                        a1.Imprimir(n);
                        Console.WriteLine("Elemento menor del arreglo: ");
                        Console.WriteLine(a1.EMenor(a, n, menor));
                        goto case 3;
                    }
                case 3: opcion = 3;
                    {
                        Console.Write("Confirme el tamaño del vector para imprimir: ");
                        n = int.Parse(Console.ReadLine());
                        a1.Imprimir(n);
                        break;
                    }
                case 4: opcion = 4;
                    {
                        Console.Clear();
                        break;
                    }
            }
            Console.WriteLine("Pulsa cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}