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
            //1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300.Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.

            int cantidadEmpleados, sueldo, importe, masDe300, entre100y300, importeTotal, cantVueltas;
            string linea;
            entre100y300 = 0;
            masDe300 = 0;
            importe = 0;

            Console.Write("Ingrese la cantidad de empleados: ");
            linea = Console.ReadLine();
            cantidadEmpleados = int.Parse(linea);
            importe = 0;

            for (int i = 0; i < cantidadEmpleados; i++)
            {

                Console.Write("Sueldo: $");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);

                importe = importe + sueldo;

                if (sueldo > 100 && sueldo < 300)
                {
                    entre100y300++;

                }
                else if (sueldo > 300)
                {
                    masDe300++;

                }
            }
            Console.WriteLine("Entre 100 y 300: " + entre100y300);
            Console.WriteLine("Más de 300: " + masDe300);
            Console.WriteLine("Importe total: $" + importe);

        }
    }
}
