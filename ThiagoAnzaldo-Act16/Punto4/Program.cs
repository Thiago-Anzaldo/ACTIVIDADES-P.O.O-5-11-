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

    public class Animal 
    {
        protected string especie;

        public string Especie 
        {
            get 
            {
                return especie;
            }

            set 
            {
                especie = value;
            }

        }
        public Animal()
        {
            Console.WriteLine(Especie);
        }
    }

    public class Mamimefero : Animal 
    {
        protected string tipoAlimentacion;

        p   ublic string TipoAlimentacion
        {
            set
            {
                tipoAlimentacion = value;
            }

        }
            get
            {
                return tipoAlimentacion;
            }
        }
        public Mamimefero() 
        {
            Console.WriteLine(tipoAlimentacion);
        }

    }

    public class Perro : Mamimefero
    {
        protected string nombre;
        public Perro()
        {

            Console.WriteLine("3");
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Especie = "asd";
            Console.WriteLine(a.Especie);


            //Mamimefero m = new Mamimefero();
            //m.TipoAlimentacion = "asd";

            //Perro p = new Perro();

            Console.ReadKey();
        }
    }
}
