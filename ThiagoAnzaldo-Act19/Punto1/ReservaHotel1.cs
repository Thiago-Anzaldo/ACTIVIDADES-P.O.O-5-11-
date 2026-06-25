using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;
        public ReservaHotel()
        {
            string linea;

            Console.Write("ingrese el nombre del cliente: ");
            nombreCliente = Console.ReadLine();

            do
            {
                Console.WriteLine("ingrese la cantidad de noche a quedarse: ");
                linea = Console.ReadLine();
                cantidadNoches = int.Parse(linea);
            } while (cantidadNoches <= 0);

            Console.Write("ingrese que tipo de habitacion desea (Simple, Doble o Suit): ");
            tipoHabitacion = Console.ReadLine();
        }

        public string NombreCliente 
        {
            set 
            { 
                nombreCliente = value;
            }
            get 
            { 
                return nombreCliente;
            }
        }
        public int CantidadNoches
        {
            set 
            {
                cantidadNoches=value;
            }
            get
            { 
                return cantidadNoches;
            }
        }
        public string TipoHabitacion
        {
            set 
            {
                tipoHabitacion = value;
            }
            get 
            { 
                return tipoHabitacion;
            }
        }
    }
}
