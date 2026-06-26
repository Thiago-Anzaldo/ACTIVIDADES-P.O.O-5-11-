using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Actividad 1: Sistema de control de vuelos
    //Problema:
    //Una aerolínea administra los vuelos programados mediante un sistema orientado a
    //objetos.
    //Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    //destino y duración en horas.Luego definir una clase derivada VueloInternacional que
    //herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    //Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    //desde consola y luego:
    // Mostrar los vuelos registrados y el país de destino.
    // Informar cuál es el vuelo con mayor duración.
    // Mostrar el orden de ejecución de los constructores.
    class Vuelo
    {
        protected int numeroVuelo;
        protected string destino;
        protected int duracion;

        public Vuelo(int numVuelo, string dest, int dur)
        {
            Console.WriteLine("CONSTRUCTOR VUELO---------------------------------");
            numeroVuelo = numVuelo;
            destino = dest;
            duracion = dur;
        }

        class VueloInternacional : Vuelo
        {
            protected string paisDestino;
            public VueloInternacional(int numVuelo, string dest, int dur, string paisDest) : base(numVuelo, dest, dur)
            {
                Console.WriteLine("CONSTRUCTOR VUELO INTERNACIONAL-------------------");
                paisDestino = paisDest;
            }

            static void Main(string[] args)
            {
                List<VueloInternacional> listaVuelos = new List<VueloInternacional>();

                for (int i = 0; i < 5; i++)
                {

                    Console.Write("ingrese el destino del vuelo: ");
                    string dest = Console.ReadLine();

                    Console.Write("ingrese su numero de vuelo: ");
                    string linea = Console.ReadLine();
                    int numVuelo = int.Parse(linea);

                    Console.Write("ingrese la duracion de su vuelo: ");
                    linea = Console.ReadLine();
                    int dur = int.Parse(linea);

                    Console.Write("ingrese el pais de su vuelo: ");
                    string paisDest = Console.ReadLine();
                    
                    VueloInternacional vi = new VueloInternacional(numVuelo, dest, dur, paisDest);
                    listaVuelos.Add(vi);
                }

                foreach (VueloInternacional v in listaVuelos) 
                {
                    Console.Write("numero de vuelo: "+v.numeroVuelo + " ");
                    Console.WriteLine("pais de destino: "+v.paisDestino);
                }

                int masLargo=0;
                int vueloLargo = 0;

                foreach(VueloInternacional v in listaVuelos) 
                {
                    if (masLargo < v.duracion) 
                    {
                        vueloLargo=v.numeroVuelo;
                    }
                }

                Console.WriteLine("el vuelo mas largo es: "+vueloLargo);

                Console.ReadKey();
            }
        }
    }
}
