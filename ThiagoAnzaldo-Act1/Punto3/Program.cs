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
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
            int num1, num2, num3, num4, suma;
            double promedio;
            string linea;

            Console.Write("Escriba el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Escriba el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Escriba el tercero numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Escriba el cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine("El promedio es: ");
            Console.WriteLine(promedio);

            Console.ReadKey();
        }
    }
}
