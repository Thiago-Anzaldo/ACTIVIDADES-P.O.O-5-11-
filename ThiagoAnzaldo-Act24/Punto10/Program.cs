using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    //10-
    //Un estacionamiento medido administra el ingreso y la salida de los vehículos que
    //utilizan su playa por orden de llegada.
    // Crear la clase Ticket que contenga como atributos privados: patente
    //(string) y horasEstadia (int). Definir sus propiedades de solo lectura y un
    //constructor que reciba pat y hs.
    // Crear la clase GestionEstacionamiento que administre una lista
    //dinámica de tickets (List).
    // Métodos en GestionEstacionamiento:
    //o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y
    //agregarlo al final de la lista utilizando .Add().
    //o ProcesarSalida(): Si la lista no está vacía, simular la salida del
    //primer vehículo de la lista (mostrar sus datos en consola) y
    //removerlo de la colección mediante.RemoveAt(0). Si está vacía,
    //advertir que no hay vehículos esperando salida.
    //o MostrarVehiculosEstacionados(): Listar todos los vehículos
    //alojados en la playa y la cantidad total de unidades presentes
    //utilizando la propiedad.Count.

    class Ticket 
    {
        private int horaEstadia;
        private string patente;

        public Ticket(string pat, int hs) 
        {
            horaEstadia= hs;
            patente= pat;
        }

        public string Patente {  get { return patente; } }
        public int HoraEstadia { get { return horaEstadia; } }
    }
    internal class GestionEstacionamiento
    {
        List<Ticket> tickets = new List<Ticket>();

        public void RegistrarIngreso() 
        {
            string pat;
            int hs;
            string linea;

            Console.WriteLine("ingrese la patente del auto: ");
            pat = Console.ReadLine();

            Console.WriteLine("ingrese su hora de salida: ");
            linea = Console.ReadLine();
            hs = int.Parse(linea);

            tickets.Add(new Ticket(pat, hs));
        }

        public void ProcesarSalida() 
        {
            if (tickets.Count!=0) 
            {
                Console.WriteLine("va salir el auto con la patente: "+tickets[0].Patente);
                Console.WriteLine("hora de estadia: " + tickets[0].HoraEstadia);

                tickets.RemoveAt(0);
            }
            else 
            {
                Console.WriteLine("No hay vehiculos esperando la salida");
            }
            Console.WriteLine("aprete ENTER para seguir");
            Console.ReadLine();
            Console.Clear();
        }  
        public void MostrarVehiculosEstacionados() 
        {
            Console.WriteLine("AUTOS EN LA PLAYA------------");
            foreach (Ticket ticket in tickets) 
            {
                Console.WriteLine(ticket.Patente);
            }
            Console.WriteLine("la cantidad de autos que hay en la playa es: "+ tickets.Count);
            Console.WriteLine("aprete ENTER para seguir");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            GestionEstacionamiento ge=new GestionEstacionamiento();
            while (true)
            {
                string opcion;
                Console.WriteLine("ingrese que funcion quiere hacer: ");
                Console.WriteLine("1.registrar ingreso");
                Console.WriteLine("2.procesar salida");
                Console.WriteLine("3.mostrar vehiculos");
                Console.WriteLine("4.terminar");
                opcion = Console.ReadLine();

                if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
                {
                    if (opcion == "1")
                    {
                        ge.RegistrarIngreso();
                    }
                    if (opcion == "2")
                    {
                        ge.ProcesarSalida();
                    }
                    if (opcion == "3")
                    {
                        ge.MostrarVehiculosEstacionados();
                    }
                    if (opcion == "4")
                    {
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("elija una de las opciones..");
                    Console.WriteLine("aprete ENTER para seguir");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
            }
        }
    }
}
