using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //    3. Plantear una clase Club y otra clase Socio.
    //      La clase Socio debe tener los siguientes atributos privados: nombre y la
    //      antigüedad en el club (en años). En el constructor pedir la carga del nombre y
    //      su antigüedad.La clase Club debe tener como atributos 3 objetos de la clase
    //      Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor
    //      antigüedad en el club.
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            nombre = "";
            antiguedad = 0;

            string linea;
            Console.Write("Ingrese un nombre: ");
            linea = Console.ReadLine();
            nombre = linea;
            Console.Write("Ingrese su antigüedad en el club: ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public int añosAntiguedad()
        {
            return antiguedad;
        }

        public string nombreSocio() 
        {
            return nombre;
        }
    }

    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club() 
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void mayorAntiguedad() 
        {
            string nombreMayor = socio1.nombreSocio();
            int antiguedadMayor = socio1.añosAntiguedad();

            if(socio2.añosAntiguedad() > antiguedadMayor)
            {
                nombreMayor = socio2.nombreSocio();
                antiguedadMayor = socio2.añosAntiguedad();
            }

            if(socio3.añosAntiguedad() > antiguedadMayor)
            {
                nombreMayor = socio3.nombreSocio();
                antiguedadMayor = socio3.añosAntiguedad();
            }

            Console.WriteLine("El socio con mayor antigüedad es: " + nombreMayor);
        }
        static void Main(string[] args)
        {
            Club club = new Club();
            club.mayorAntiguedad();
            Console.ReadKey();
        }
    }
}