using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3.MergeEstados
{
    class Program
    {
        class Merge
        {
            string[] vector = new string[] { "Aguascalientes", "Mexicali", "La Paz", "San Francisco de Campeche", "Tuxtla Gutiérrez", "Chihuahua", "Ciudad de México", "Saltillo", "Colima", "Victoria de Durango", "Guanajuato", "Chipancingo de los Bravo", "Pachuca de Soto", "Guadalajara", "Toluca de Lerdo", "Morelia", "Cuernavaca", "Tepic", "Monterrey", "Oaxaca de Juárez", "Puebla de Zaragoza", "Santiago de Querétaro", "Chetumal", "San Luis Potosí", "Culiacán Rosales", "Hermosillo", "Villahermosa", "Ciudad Victoria", "Tlaxcala de Xicohténcatl", "Xalapa-Enríquez", "Mérida", "Zacatecas" };

            public void Inicializar()
            {
                Random random = new Random();
                for (int c = 0; c <= 31; c++)
                {
                    string temp = vector[c];
                    int i = random.Next(0, 31);
                    vector[c] = vector[i];
                    vector[i] = temp;
                }
            }
            public void Imprimir()
            {
                for (int c = 0; c <= 31; c++)
                {
                    Console.WriteLine((c + 1) + ". {0} ", vector[c]);
                }
            }
            public void Mezclar()
            {
                bool up = true;
                int p = 1;
                int k, l, i, j, q, r, t;
                int n = 31;
                do
                {
                    int h = 1;
                    int m = n;
                    if (up == true)
                    {
                        i = 1;
                        j = n;
                        k = n + 1;
                        l = (2 * n);
                    }
                    else
                    {
                        k = 1;
                        l = n;
                        i = n + 1;
                        j = (2 * n);
                    }
                    do
                    {
                        if (m >= p)
                        {
                            q = p;
                        }
                        else
                        {
                            q = m;
                        }
                        m = m - q;
                        if (m >= p)
                        {
                            r = p;
                        }
                        else
                        {
                            r = m;
                        }
                        m = m - r;
                        while (q != 0&&r!=0)
                        {
                            if (string.Compare(vector[i],vector[j])<1)
                            {
                                vector[k] = vector[i];
                                k = k + h;
                                i = i - 1;
                                q--;
                            }
                            else
                            {
                                vector[k] = vector[j];
                                k = k + h;
                                j--;
                                r--;
                            }
                        }
                        while (r > 0)
                        {
                            vector[k] = vector[j];
                            k = k + h;
                            j--;
                            r--;
                        }
                        while (q > 0)
                        {
                            vector[k] = vector[i];
                            k = k + h;
                            i++;
                            q--;
                        }
                        h = -h;
                        t = k;
                        k = l;
                        l = t;
                    }
                    while (m != 0);
                    up = !up;
                    p = 2 * p;
                }
                while (p <= n);
                if (up == false)
                {
                    for (int x = 0; x <= n - 1; x++)
                    {
                        vector[x] = vector[x + n];
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Merge merge = new Merge();
            int opcion;
            Menu();

            void Menu()
            {
                Console.WriteLine("MENU MERGE");
                Console.WriteLine("1. Generar arreglo");
                Console.WriteLine("2. Desplazar el arreglo");
                Console.WriteLine("3. Mezclar el arreglo");
                Console.WriteLine("4. Salir del programa");
                Console.Write('\n' + "Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        opcion = 1;
                        {
                            Console.Clear();
                            merge.Inicializar();
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
                            merge.Imprimir();
                            Console.ReadKey();
                            Console.Clear();
                            Menu();
                            break;
                        }
                    case 3:
                        opcion = 3;
                        {
                            Console.Clear();
                            merge.Mezclar();
                            Console.WriteLine("Mezcla realizada con éxito");
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
