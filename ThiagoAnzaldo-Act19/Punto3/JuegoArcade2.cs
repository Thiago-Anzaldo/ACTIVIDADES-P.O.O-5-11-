using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        public bool Partida() 
        {
            string linea;
            int puntaje;
            bool rompioRecord=false;

            Console.Write("ingrese el puntaje hecho: ");
            linea= Console.ReadLine();
            puntaje=int.Parse(linea);

            if (puntaje > PuntajeMaximo) 
            {
                rompioRecord = true;
            }
            return rompioRecord;
        }
    }
}
