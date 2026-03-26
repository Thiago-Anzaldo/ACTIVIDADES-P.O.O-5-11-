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
            //3. Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

            int num1;
            string linea;

            Console.WriteLine("ingrese un numero: ");
            linea = Console.ReadLine();
            num1=int.Parse(linea);

            if (num1 > 0) {
                if (num1 < 100) {
                    if (num1 < 10)
                    {
                        Console.WriteLine("su numero es de un digito");
                    }
                    else {
                        Console.WriteLine("su numero es de dos0 digito");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
