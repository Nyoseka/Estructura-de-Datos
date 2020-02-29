using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23.Burbuja
{
    class Program
    {
        class Burbuja
        {
            string[] vector = new string[] {"Aguascalientes","Mexicali","La Paz","San Francisco de Campeche","Tuxtla Gutiérrez","Chihuahua","Ciudad de México","Saltillo","Colima","Victoria de Durango","Guanajuato","Chipancingo de los Bravo","Pachuca de Soto","Guadalajara","Toluca de Lerdo","Morelia","Cuernavaca","Tepic","Monterrey","Oaxaca de Juárez","Puebla de Zaragoza","Santiago de Querétaro","Chetumal","San Luis Potosí","Culiacán Rosales","Hermosillo","Villahermosa","Ciudad Victoria","Tlaxcala de Xicohténcatl","Xalapa-Enríquez","Mérida","Zacatecas"};
            public void Inicializar()
            {
                Random random = new Random();
                for(int c = 0; c <= 31; c++)
                {
                    string temp=vector[c];
                    int i = random.Next(0, 31);
                    vector[c] = vector[i];
                    vector[i] = temp;
                }
            }
            public void Imprimir()
            {
                for (int c = 0; c <= 31; c++)
                {
                    Console.WriteLine((c+1)+". {0} ", vector[c]);
                }
            }
            public void OrdenamientoBurbuja()
            {
                string temp;
                int n = vector.Length - 1;
                for (int k= 1; k <=n-1; k++)
                {
                    for (int l = 0; l <=n-k; l++)
                    {
                        if (string.Compare(vector[l], vector[l+1])>-1)
                        {
                            temp = vector[l];
                            vector[l] = vector[l + 1];
                            vector[l + 1] = temp;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Burbuja burbuja = new Burbuja();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU METODO DE BURBUJA");
                Console.WriteLine("1. Inicializar arreglo");
                Console.WriteLine("2. Desplazar el arreglo");
                Console.WriteLine("3. Ordenar el arreglo");
                Console.WriteLine("4. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            burbuja.Inicializar();
                            Console.WriteLine("Arreglo inicializado con éxito");
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 2:
                        opcion = 2;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO: ");
                            burbuja.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            Console.WriteLine("ARREGLO ORDENADO COBN ÉXITO");
                            burbuja.OrdenamientoBurbuja();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 4:
                        opcion = 4;
                        {
                            Console.Clear();
                            Console.Write("Pulsa cualquier tecla para salir");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opción inválida");
                            break;
                        }
                }
            }
        }
    }
}
