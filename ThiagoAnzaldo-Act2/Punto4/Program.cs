using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.

            int num1,num2,num3;
            string linea;

            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("ingrese el tercero numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("el mayor numero es: ");
                    Console.WriteLine(num1);
                }
            }
            if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el mayor numero es: ");
                    Console.WriteLine(num2);
                }
            }
            if (num3 > num1)
            {
                if (num3 > num2)
                {
                    Console.WriteLine("el mayor numero es: ");
                    Console.WriteLine(num3);
                }
            }
            Console.ReadKey();
        }
    }
}
