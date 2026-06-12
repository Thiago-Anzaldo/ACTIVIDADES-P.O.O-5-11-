using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //4. Cadena de Herramientas(Herencia Multinivel y Orden de Constructores)
    //    Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
    //    herencia: Material, Herramienta y Martillo.
    //     La clase Material(base) debe tener un atributo TipoMaterial(ej: Madera, Acero,
    //    Plástico).
    //     La clase Herramienta(que hereda de Material) debe añadir el atributo
    //    FuncionPrincipal.
    //     La clase Martillo(que hereda de Herramienta) debe añadir el atributo PesoGramos.
    //    Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
    //    correspondientes.Al momento de ejecutarse, cada constructor debe realizar la asignación y,
    //    acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
    //    (ejemplo: &quot; Constructor de la clase Material ejecutado&quot;).
    //    En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
    //    parámetros requeridos.Observar y verificar en la consola el orden secuencial de ejecución
    //    en cadena de los constructores(desde la raíz hasta la clase derivada).
    
    class Material 
    {
        private string TipoMaterial;
        public Material() 
        {
            Console.Write("Ingrese el tipo del material: ");
            TipoMaterial = Console.ReadLine();
            Console.WriteLine("CONSTRUCTOR DE LA CLASE MATERIAL EJECUTADO");
        }

        public string ObtenerTipoMaterial 
        {
            get 
            { 
                return TipoMaterial;
            }
        }
    }

    class Herramienta : Material 
    {
        private string FuncionPrincipal;
        public Herramienta() 
        {
            Console.Write("Ingrese la funcion principal: ");
            FuncionPrincipal = Console.ReadLine();
            Console.WriteLine("CONSTRUCTOR DE LA CLASE HERRAMIENTA EJECUTADO");
        }

    }
    class Martillo : Herramienta
    {
        private string PesoGramos;
        public Martillo()
        {
            Console.Write("Ingrese el Peso en gramos: ");
            PesoGramos = Console.ReadLine();
            Console.WriteLine("CONSTRUCTOR DE LA CLASE MARTILLO EJECUTADO");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Martillo m = new Martillo();

            Console.ReadKey();
        }
    }
}
