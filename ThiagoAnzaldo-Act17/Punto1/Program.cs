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

    public class PersonaGimnasio
    {
        private string nombre;
        private int dni;


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
            Console.WriteLine("\n");
        }

    }

    public class Profesor : PersonaGimnasio
    {
        private string especialidad;

        public void aProfesor()
        {
            especialidad = "correr";
            Console.WriteLine("Nombre profesor: "+Nombre);
            Console.WriteLine("dni: "+Dni);
            Console.WriteLine("especialidad: "+especialidad);
        }
        static void Main(string[] args)
        {

            PersonaGimnasio pg = new PersonaGimnasio();
            pg.Nombre = "juansito";
            pg.Dni = 2;
            pg.muestraPersonaGimnasio();

            Profesor p = new Profesor();
            p.Dni = 3;
            p.Nombre = "juan";
            p.aProfesor();
            Console.ReadKey();
        }
    }
}
