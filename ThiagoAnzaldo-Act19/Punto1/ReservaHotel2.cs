using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    partial class ReservaHotel
    {

        public int PagoTotal()
        {
            int totalAPagar=0;
            if (TipoHabitacion == "Simple")
            {
                totalAPagar = CantidadNoches * 5000;
                return totalAPagar;
            }
            if (TipoHabitacion == "Doble")
            {
                totalAPagar = CantidadNoches * 8000;
                return totalAPagar;
            } 
            if (TipoHabitacion == "Suit")
            {
                totalAPagar = CantidadNoches * 12000;
                return totalAPagar;
            }
            return totalAPagar;
        }
    }
}
