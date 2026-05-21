using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto1
{
    class Empleado
    {
        //1. Confeccionar una clase que represente un empleado.Definir como atributos su
        //nombre y su sueldo.En el constructor cargar los atributos y luego en otro
        //método imprimir sus datos y por último uno que imprima un mensaje si debe
        //pagar impuestos(si el sueldo supera a 3000)
        private string nombre;
        private int sueldo;

        public Empleado() 
        {
            string linea;

            Console.Write("nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo=int.Parse(linea);
        }

        public void Imprimir() 
        {
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Sueldo del empleado: " + sueldo);
        }

        public void Impuestos() 
        {
            if (sueldo > 3000) 
            {
                Console.WriteLine("Debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.Imprimir();
            emp.Impuestos();
            Console.ReadKey();
        }
    }
}