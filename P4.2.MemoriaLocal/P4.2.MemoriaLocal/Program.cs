using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4._2.MemoriaLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            double mochilaprecio = 320.00;
            double playeraprecio = 120.50;
            double pantalonprecios = 250.00;
            double zapatosprecios = 550.20;
            int opcion;
            int cantidad;
            double monto;
            Console.WriteLine("Bienvenido, estimado cliente");
            Console.WriteLine("Seleccione las opcion que desee comprar");
            Console.WriteLine("1. Mochila");
            Console.WriteLine("2. Playera");
            Console.WriteLine("3. Pantalon");
            Console.WriteLine("4. Zapatos");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                opcion = 1;
                {
                    Console.Clear();
                    Console.WriteLine("Articulo: Mochila");
                    Console.Write("Escriba la cantidad de unidades que desea adquirir: ");
                    cantidad = int.Parse(Console.ReadLine());
                    Console.Write("Monto Total: ");
                    MontoMochila();
                    Console.Write("${0}"+'\n',monto);
                    break;
                }
                case 2:
                    {
                        Console.Clear();
                        Console.Write("Escriba la cantidad de unidades que desea adquirir: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Monto Total: ");
                        MontoPlayera();
                        Console.Write("${0}" + '\n', monto);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Articulo: Pantalon");
                        Console.Write("Escriba la cantidad de unidades que desea adquirir: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Monto Total: ");
                        MontoPantalon();
                        Console.Write("${0}" + '\n', monto);
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.Write("Escriba la cantidad de unidades que desea adquirir: ");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Monto Total: ");
                        MontoZapatos();
                        Console.Write("${0}" + '\n', monto);
                        break;
                    }
            }
            Console.WriteLine("Gracias por visitarnos" + '\n');
            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();

                void MontoMochila()
                {
                    monto = cantidad * mochilaprecio;
                }
                void MontoPlayera()
                {
                    monto = cantidad * playeraprecio;
                }
                void MontoPantalon()
                {
                    monto = cantidad * pantalonprecios;
                }
                void MontoZapatos()
                {
                    monto = cantidad * zapatosprecios;
                }
        }
    }
}
