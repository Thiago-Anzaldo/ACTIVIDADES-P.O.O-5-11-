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
            /*3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/

            int valorIngresado, cantPositivos, cantNegativos, cantMultiplosDe15, valorAcumuladoDePares;
            string linea;

            valorAcumuladoDePares = 0;
            cantMultiplosDe15 = 0;
            cantNegativos = 0;
            cantPositivos = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un valor: ");
                linea = Console.ReadLine();
                valorIngresado = int.Parse(linea);

                if (valorIngresado > 0)
                {
                    cantPositivos++;
                }
                else if (valorIngresado < 0)
                {
                    cantNegativos++;
                }
                if (valorIngresado % 15 == 0)
                {
                    cantMultiplosDe15++;
                }
                if (valorIngresado % 2 == 0)
                {
                    valorAcumuladoDePares = valorAcumuladoDePares + valorIngresado;
                }
            }
            Console.WriteLine("cantidad de positivos: " + cantPositivos);
            Console.WriteLine("cantidad de negativos: " + cantNegativos);
            Console.WriteLine("cantidad de multiplos de 15: " + cantMultiplosDe15);
            Console.WriteLine("valor acumulado de pares: " + valorAcumuladoDePares);

            Console.ReadKey();
        }
    }
}
