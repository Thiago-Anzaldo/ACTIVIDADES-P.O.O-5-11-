using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
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