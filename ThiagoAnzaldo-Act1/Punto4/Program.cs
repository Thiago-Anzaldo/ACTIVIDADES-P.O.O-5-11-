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
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.

            int precio, cantidad, abonar;
            string linea;

            Console.Write("Precio de la manzana: ");
            linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.Write("Cantidad que se desea llevar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            abonar = precio * cantidad;

            Console.WriteLine("Debe abonar: ");
            Console.WriteLine(abonar);

            Console.ReadKey();
        }
    }
}
