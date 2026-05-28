using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //    2. Control de Vuelos
    //Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos(peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
    //Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero.Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
    //Agregar los siguientes métodos en la clase Vuelo:
    //  Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
    //  Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
    //  Un método que informe si algún pasajero excede el límite permitido de equipaje(mayor a 23 kg), imprimiendo su nombre y su DNI.
    class Pasajero
    {
        private string nombre;
        private int dni;
        private double equipajeKilos;

        public Pasajero()
        {
            string linea = "";

            Console.Write("Escriba su nombre: ");
            nombre= Console.ReadLine();

            Console.Write("Escriba su dni: ");
            linea = Console.ReadLine();
            dni = int.Parse(linea);

            Console.Write("Escriba el peso de su equipaje: ");
            linea = Console.ReadLine();
            equipajeKilos = double.Parse(linea);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
