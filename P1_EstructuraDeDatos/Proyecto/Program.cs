using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            const double tarifabase = 8.5;
            const double tarifaviaje = 4.7;
            int opcion;
            int[] viajesdia = new int[5];
            int[] semana1 = new int[7];
            double[] tsemana1 = new double[7];
            int suma1 = 0;
            int sumadia = 0;
            double subtotal1 = 0;
            double total = 0;
            double distancia;
            double costo;
            Console.WriteLine("Base de Datos Uber");
            Console.WriteLine("Elija una opción" + '\n');
            Console.WriteLine("1. Kilometraje realizado en el día");
            Console.WriteLine("2. Kilometraje realizado durante la semana");
            Console.WriteLine("3. Calcular el precio de un viaje");
            Console.WriteLine("4. Consultar dinero");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    opcion = 1;
                    {
                        Console.WriteLine("Kilometraje realizado durante el día");
                        Console.WriteLine("Se considera que ha tenido cinco viajes en el día" + '\n');
                        Console.WriteLine("   -------   ");
                        Console.WriteLine("Ingrese los kilometros que ha recorrido");
                        lecturadia();
                        for (int c = 0; c <= 4; c++)
                        {
                            sumadia = sumadia + viajesdia[c];
                        }
                        Console.WriteLine("Kilometros recorridos en el día: " + sumadia + '\n');
                        Console.WriteLine("Pulsa cualquier tecla para salir");
                        break;
                    }

                case 2:
                    opcion = 2;
                    {
                        Console.WriteLine("Kilometraje realizado durante la semana" + '\n');
                        Console.WriteLine("   -------   ");
                        Console.WriteLine("Ingrese los kilometros que ha recorrido");
                        datosSemana1();
                        for (int c = 0; c <= 6; c++)
                        {
                            suma1 = suma1 + semana1[c];
                        }
                        Console.WriteLine("Kilometros recorridos en la Semana: " + suma1 + '\n');
                        Console.WriteLine("Pulsa cualquier tecla para salir");
                        break;
                    }
                case 3:
                    opcion = 3;
                    {
                        Console.WriteLine("Calcular el precio de un viaje" + '\n');
                        Console.WriteLine("   -------   ");
                        Console.WriteLine("Ingrese la distancia a recorrer");
                        distancia = double.Parse(Console.ReadLine());
                        costo = tarifabase + (tarifaviaje * distancia);
                        Console.WriteLine("El costo un viaje de " + distancia + "km " + "es: " + costo);
                        Console.WriteLine("Pulsa cualquier tecla para salir");
                        break;
                    }

                case 4:
                    opcion = 4;
                    {
                        Console.WriteLine("Consultar dinero");
                        Console.WriteLine("   -------   " + '\n');
                        Console.WriteLine("Elije una opción");
                        Console.WriteLine("1. Dinero por día");
                        Console.WriteLine("2. Dinero por semana");
                        int op;
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                op = 1;
                                {
                                    Console.WriteLine("DINERO TOTAL DEL DIA" + '\n');
                                    Console.WriteLine("   -------   ");
                                    Console.WriteLine("Ingresa los viajes realizados");
                                    lecturadia();
                                    Console.WriteLine("Total Neto: " + dia(subtotal1));
                                    Console.WriteLine("Porcentaje de la empresa: " + (dia(subtotal1) * 0.25));
                                    Console.WriteLine("Porcentaje para el usuario: " + (dia(subtotal1) * 0.75));
                                    Console.WriteLine("Pulsa cualquier tecla para salir");
                                    break;
                                }

                            case 2:
                                op = 2;
                                {
                                    Console.WriteLine("DINERO TOTAL DE LA SEMANA" + '\n');
                                    Console.WriteLine("   -------   ");
                                    Console.WriteLine("Ingresa los viajes que realizado");
                                    datosSemana1();
                                    Console.WriteLine("Total Neto: " + dia(subtotal1) + '\n');
                                    Console.WriteLine("Porcentaje de la empresa: " + (semana(total) * 0.25));
                                    Console.WriteLine("Porcentaje para el usuario: " + (semana(total) * 0.75));
                                    Console.WriteLine("Pulsa cualquier tecla para salir");
                                }
                                break;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                        Console.WriteLine("Pulsa cualquier tecla para salir");
                        break;
                    }
            }
            Console.ReadKey();

            void datosSemana1()
            {
                for (int c = 0; c <= 6; c++)
                {
                    semana1[c] = int.Parse(Console.ReadLine());
                }
            }
            void lecturadia()
            {
                for (int c = 0; c <= 4; c++)
                {
                    viajesdia[c] = int.Parse(Console.ReadLine());
                }
            }
            double dia(double suma)
            {
                for (int c = 0; c <= 4; c++)
                {
                    suma = suma + (tarifabase + (tarifaviaje * Convert.ToDouble(viajesdia[c])));
                }
                return suma;
            }
            double semana(double sumasemana)
            {
                for (int c = 0; c <= 6; c++)
                {
                    sumasemana = sumasemana + (tarifabase + (tarifaviaje * Convert.ToDouble(semana1[c])));
                }
                return sumasemana;
            }
        }
    }
}
