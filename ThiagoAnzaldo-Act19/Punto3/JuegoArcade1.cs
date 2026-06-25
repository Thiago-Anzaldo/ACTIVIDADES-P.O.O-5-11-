using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    partial class JuegoArcade
    {
        protected string nombreJuego;
        protected int puntajeMaximo;
        protected int nivelDificultad;

        public JuegoArcade()
        {
            string linea;

            Console.Write("ingrese el nombre del juego: ");
            nombreJuego = Console.ReadLine();

            Console.Write("ingrese la dificultad del juego (del 1 al 5)");
            linea = Console.ReadLine();
            nivelDificultad = int.Parse(linea);

            Console.Write("ingrese el puntaje maximo: ");
            linea = Console.ReadLine();
            puntajeMaximo=int.Parse(linea);
        }

        public string NombreJuego 
        {
            get 
            { 
                return nombreJuego;
            }
        }
        public int PuntajeMaximo 
        {
            get 
            {
                return puntajeMaximo;
            }
        }
        public int NivelDificultad 
        {
            get 
            {
                return nivelDificultad;
            }
        }
    }
}
