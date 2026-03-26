using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
            int radio;
            double circunferencia,area;
            string linea;

            Console.Write("Ingrese un radio: ");
            linea = Console.ReadLine();
            radio =int.Parse(linea);

            area = 3.1416 * radio * radio;
            circunferencia = 3.1416 * (radio*2);

            Console.WriteLine("la circunferencia es: ");
            Console.WriteLine(circunferencia);
            Console.WriteLine("el area es: ");
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
