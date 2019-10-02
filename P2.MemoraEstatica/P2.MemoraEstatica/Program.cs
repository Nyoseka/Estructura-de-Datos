using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.MemoraEstatica
{
    public class Empleado
    {
        public int id;
        public string nombre;
        public Empleado()
        { }
        public Empleado(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public static int contador;
        public static int CEmpleado()
        {
            return contador++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string nombre;
            string c;
            Console.Write("Ingresa el ID del empleado: ");
            id=int.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre del empleado: ");
            nombre=Console.ReadLine();
            Empleado empleado = new Empleado(id, nombre);
            Console.Write("Indica el numero de empleado(s) actual: ");
            c = Console.ReadLine();
            Empleado.contador = int.Parse(c);
            Empleado.CEmpleado();
                Console.WriteLine("   ---------   ");
                Console.WriteLine("REGISTRO DE USUARIOS. DATOS DEL EMPLEADO");
                Console.WriteLine("Nombre del empleado: {0}",empleado.nombre);
                Console.WriteLine("ID del empleado: {0}", empleado.id);
                Console.Write("Empleado registrado. Numero actual de empleados: {0}", Empleado.CEmpleado());

            Console.ReadKey();
        }
    }
}
