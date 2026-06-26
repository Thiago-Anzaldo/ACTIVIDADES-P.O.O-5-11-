using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //1. Plantear una clase parcial ReservaHotel.
    //    En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
    //    TipoHabitacion(puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
    //    noches sea mayor a 0. Estos valores son cargados desde la consola.
    //    En el segundo archivo, agregar un método que calcule el total a pagar según la
    //    habitación elegida(por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
    //    noche).
    //    Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.
    internal class Program
    {
        static void Main(string[] args)
        {
            ReservaHotel rh1 = new ReservaHotel();
            ReservaHotel rh2 = new ReservaHotel();
            ReservaHotel rh3 = new ReservaHotel();

            if (rh1.PagoTotal() > rh2.PagoTotal() && rh1.PagoTotal()> rh3.PagoTotal()) 
            {
                Console.WriteLine("el cliente "+rh1.NombreCliente+" pagara mas con " + rh1.PagoTotal());
            }
            if (rh2.PagoTotal() > rh1.PagoTotal() && rh2.PagoTotal() > rh3.PagoTotal())
            {
                Console.WriteLine("el cliente " + rh2.NombreCliente + " pagara mas con "+rh2.PagoTotal());
            }
            if (rh3.PagoTotal() > rh2.PagoTotal() && rh3.PagoTotal() > rh1.PagoTotal())
            {
                Console.WriteLine("el cliente " + rh3.NombreCliente + " pagara mas con "+rh3.PagoTotal());
            }

            Console.ReadKey();
        }
    }
}