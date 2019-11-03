using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9.TorresDeHanoi
{
    class Program
    {
        public static int cont;
        public class Hanoi
        {
            public void TorresDeHanoi(int n,string origen, string auxiliar, string destino)
            {
                if(n==1)
                {
                    Console.WriteLine("Se mueve un disco de {0} a {1}",origen,destino);
                    cont++;
                }
                else
                {
                    TorresDeHanoi(n - 1, origen, auxiliar, destino);
                    Console.WriteLine("Se mueve un disco de {0} a {1}", origen, destino);
                    cont++;
                    TorresDeHanoi(n - 1, origen, auxiliar, destino);
                }
            }
        }
        static void Main(string[] args)
        {
            Hanoi hanoi = new Hanoi();
            int opcion;
            Console.WriteLine("MENU TORRES DE HANOI");
            Console.WriteLine("1. Calcular y Desplegar Total de Movimientos");
            Console.WriteLine("2. Salir"+'\n');
            Console.Write("Selecciona una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: opcion = 1;
                    {
                        Console.Clear();
                        int num;
                        string origen = "Torre 1";
                        string auxiliar = "Torre 2";
                        string destino = "Torre 3";
                        Console.Write("Ingresa la cantidad de anillos: ");
                        num = int.Parse(Console.ReadLine());
                        hanoi.TorresDeHanoi(num, origen, auxiliar, destino);
                        Console.WriteLine("Movimientos realizados: {0}",cont);
                        break;
                    }
                case 2: opcion = 2;
                    {
                        Console.Clear();
                        break;
                    }
            }
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
