using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int valorIngresado, suma;
            string linea;
            bool corte;

            corte = true;
            valorIngresado = 0;
            suma = 0;
            do
            { 
                Console.WriteLine("ingrese un valor");
                linea = Console.ReadLine();
                valorIngresado = int.Parse(linea);

                if (valorIngresado == 9999)
                {
                    corte = false;
                }
                else { 
                    suma = valorIngresado + suma;
                    Console.WriteLine("el nuevo valor es: "+ suma);
                }
            } while (corte==true);

            if (suma>0)
            {
                Console.WriteLine(suma + " es mayor a 0");
            }
            else if (suma < 0)
            {
                Console.WriteLine(suma + " es menor a 0");
            }
            else
            {
                Console.WriteLine("el valor es igual a 0");
            }
            Console.ReadKey();
        }
    }
}
