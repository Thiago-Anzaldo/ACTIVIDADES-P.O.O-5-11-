    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.ConstrainedExecution;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    namespace Punto4
    {
        //4. Armar tres clases: Animal, Mamífero y Perro.
        //La clase Animal debe tener un atributo especie.
        //La clase Mamífero, que hereda de Animal, debe tener un atributo
        //tipoAlimentacion.
        //La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        //Cada clase debe tener un constructor que reciba los datos correspondientes
        //y los imprima indicando a qué clase pertenecen.Los datos deben ser
        //asignados previamente
        //Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
        //constructores.

        class Animal
        {
            protected string especie;

            public Animal()
            {
                especie="mamifero";
            Console.WriteLine(especie+" (clase animal)");
            }
        }


            class Mamifero : Animal
            {
            private string tipoAlimentacion;

            public Mamifero()
            {
                tipoAlimentacion = "carnivoro";
            Console.WriteLine(tipoAlimentacion + " (clase mamifero)");
        }

            public class Perro : Mamifero
            {
                private string nombre;
                public Perro() 
                {
                    nombre = "preguntale";
                Console.WriteLine(nombre + " (clase perro)");
            }

            }

            class Prueba
            {
                static void Main(string[] args)
                {
                    Perro p = new Perro();
                    Console.ReadKey();
                }
            }
        }
    }
