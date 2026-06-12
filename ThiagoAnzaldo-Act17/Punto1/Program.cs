using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //1. Personal de un Gimnasio(Herencia Simple y Propiedades)
    //Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
    //Nombre y el DNI(definir sus respectivas propiedades de lectura y escritura). Plantear un
    //método para imprimir estos datos básicos.
    //Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
    //un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
    //para imprimir todos los datos del profesor(incluyendo los heredados).
    //En el programa principal(Main):
    // Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
    //llamar a su método de impresión.
    // Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
    //que puede acceder tanto a sus métodos propios como a los de la clase base.

    class PersonaGimnasio
    {
        private string nombre;
        private int dni;


        //public PersonaGimnasio()
        //{
        //    string linea;
        //    Console.Write("Ingrese el nombre: ");
        //    nombre = Console.ReadLine();

        //    Console.Write("Ingrese su dni (sin espacios): ");
        //    linea = Console.ReadLine();
        //    dni = int.Parse(linea);
        //}
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

        public int Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                return dni;
            }
        }

        public void muestraPersonaGimnasio()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Dni: " + dni);
        }
    }

    class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public Profesor()
        {

            Console.Write("Ingrese la especialidad del profesor: ");
            especialidad = Console.ReadLine();

        }
        public void muestra()
        {
            Console.WriteLine(Nombre);
        }
        static void Main(string[] args)
        {

            PersonaGimnasio pg = new PersonaGimnasio();
            pg.Nombre = "asd";
            pg.Dni = 2;
            pg.muestraPersonaGimnasio();


            Profesor p = new Profesor();
            p.muestra();
            Console.ReadKey();
        }
    }
}
