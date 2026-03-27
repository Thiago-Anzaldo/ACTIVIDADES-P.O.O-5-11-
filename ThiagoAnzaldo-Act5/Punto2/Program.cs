using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad.*/

            int cantTriangulos, cantIsos, cantEqui, cantEsc, lado1, lado2, lado3;
            string linea;

            cantEqui = 0;
            cantEsc = 0;
            cantIsos = 0;

            Console.Write("Ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            cantTriangulos = int.Parse(linea);

            for (int i = 1; i < cantTriangulos + 1; i++)
            {
                Console.WriteLine("TRIANGULO " + i);

                Console.Write("Ingrese el lado 1: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("Ingrese el lado 2: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("Ingrese el lado 3: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado2 == lado3)
                {
                    cantEqui++;
                }
                else if (lado1 != lado2 && lado2 != lado3)
                {
                    cantEsc++;
                }
                else
                {
                    cantIsos++;
                }
            }
            Console.WriteLine("cantidad de equilateros: " + cantEqui);
            Console.WriteLine("cantidad de isosceles: " + cantIsos);
            Console.WriteLine("cantidad de escalenos: " + cantEsc);

            if (cantEqui < cantIsos && cantEqui < cantEsc)
            {
                Console.WriteLine("el equilatero tiene menor cantidad");
            }
            if (cantIsos < cantEqui && cantIsos < cantEsc)
            {
                Console.WriteLine("el isosceles tiene menor cantidad");
            }
            if(cantEsc<cantEqui&&cantEsc<cantIsos){
                Console.WriteLine("el escaleno tiene menor cantidad");
            }

            Console.ReadKey();
        }
    }
}
