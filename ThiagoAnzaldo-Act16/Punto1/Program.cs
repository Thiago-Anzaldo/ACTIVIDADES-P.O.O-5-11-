using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //1. Confeccionar una clase Persona que tenga como atributos el nombre y la
    //edad(definir las propiedades para poder acceder a dichos atributos). Definir
    //un método para imprimirlos.Plantear una segunda clase Empleado que
    //herede de la clase Persona.Añadir un atributo sueldo (y su propiedad) y el
    //método para imprimir su sueldo.Definir un objeto de la clase Persona y
    //llamar a sus métodos y propiedades.También crear un objeto de la clase
    //Empleado y llamar a sus métodos y propiedades.
    class Persona 
    {
        protected string nombre;
        protected int edad;

        public string Nombre 
        {
            set 
            {
                nombre = value;
            }
            get 
            { 
                return nombre; 
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void muestraPersona()
        {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("edad: "+edad);

        }
    }
    class Empleado :Persona
    {
        private int sueldo;

        public int Sueldo 
        {
            set 
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public void muestraEmpleado()
        {
            Console.WriteLine("Nombre: "+ nombre);
            Console.WriteLine("edad: "+ edad);
            Console.WriteLine("sueldo: "+ sueldo);
        }
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "mohamed";
            p1.Edad = 67;
            p1.muestraPersona();
            Console.WriteLine("\n");

            Persona p2 = new Persona();
            p2.Nombre = "rober";
            p2.Edad = 71;
            p2.muestraPersona();
            Console.WriteLine("\n");

            Empleado e = new Empleado();
            e.Nombre = "benson";
            e.Edad = 45;
            e.Sueldo = 300;
            e.muestraEmpleado();
            Console.WriteLine("\n");

            Empleado e2 = new Empleado();
            e2.Nombre = "pepe";
            e2.Edad = 15;
            e2.Sueldo = 30;
            e2.muestraEmpleado();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
