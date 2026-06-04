using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    class NaveEspacial
    {
        private string NombreNave;

        public NaveEspacial()
        {
            Console.Write("Ingrese el nombre de la nave: ");
            NombreNave = Console.ReadLine();
        }   

        public string nombreNave()
        {
            return NombreNave;
        }
    }

    class PuertoControl
    {


        static void Main(string[] args)
        {
        }
    }
}
