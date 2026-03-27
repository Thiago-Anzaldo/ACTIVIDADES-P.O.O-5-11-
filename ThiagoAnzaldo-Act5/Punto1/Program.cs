using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            muestre la tabla de multiplicar del mismo (los primeros 13 términos)
            Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
            39.*/

            int numeroIngresado;
            string linea;

            Console.Write("escriba un numero del 1 al 10: ");
            linea = Console.ReadLine();
            numeroIngresado = int.Parse(linea);

            if (numeroIngresado > 0 && numeroIngresado < 10)
            {
                for (int i = 1; i <=13; i++)
                {
                    Console.WriteLine(i * numeroIngresado);
                }

            }
            else
            {
                Console.WriteLine("RESPETE EL RANGO DEL 1 AL 10 PORFAVOR");
            }

            Console.ReadKey();
        }
    }
}
