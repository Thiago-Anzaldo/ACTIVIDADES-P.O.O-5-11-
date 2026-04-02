using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Empleado
    {
        /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
        sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        (si el sueldo supera a 3000).*/
        private int sueldo;
        private string nombre;

        public void CargarDatos()
        {
            string linea;
            Console.Write("Escriba el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("Escriba el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }
        public void Impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.CargarDatos();
            empleado.ImprimirDatos();
            empleado.Impuestos();
            Console.ReadKey();
        }

    }
}