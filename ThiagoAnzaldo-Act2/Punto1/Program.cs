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
            //1. Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.

            int num1, num2, suma, resta, producto;
            float division;
            string linea;

            Console.Write("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1= int.Parse(linea);

            Console.Write("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if (num1 > num2)
            {
                suma = num1 + num2;
                resta= num1 - num2;

                Console.WriteLine("su suma es: ");
                Console.WriteLine(suma);
                Console.WriteLine("su resta es: ");
                Console.WriteLine(resta);
            }
            else
            {
                producto = num1 * num2;
                division = num1 / num2;
                Console.WriteLine("su producto es: ");
                Console.WriteLine(producto);
                Console.WriteLine("su division es: ");
                Console.WriteLine(division);
            }
            Console.ReadKey();
        }
    }
}
