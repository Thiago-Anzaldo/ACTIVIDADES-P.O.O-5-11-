using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
    un videojuego. El programa debe:
     Mostrar la puntuación más alta y la más baja.
     Calcular el promedio de puntuación.
     Contar cuántas veces superó los 500 puntos.*/
    internal class Puntuaciones
    {
        private int[] puntuacion;

        public void Carga()
        {
            string linea;
            puntuacion = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("ingresa las puntuaciones de la partida: ");
                linea = Console.ReadLine();
                puntuacion[i] = int.Parse(linea);
            }
        }
        public void PuntuacionMasAltaYBaja()
        {
            int puntuacionMasAlta = 0;
            int puntuacionMasBaja = 0;

            puntuacionMasBaja = puntuacion[0];
            for (int i = 0; i < 6; i++)
            {
                if (puntuacion[i] > puntuacionMasAlta)
                {
                    puntuacionMasAlta = puntuacion[i];
                }
                if (puntuacion[i] < puntuacionMasBaja)
                {
                    puntuacionMasBaja=puntuacion[i];
                }
            }
            Console.WriteLine("La puntuacion mas alta fue :"+puntuacionMasAlta);
            Console.WriteLine("La puntuacion mas baja fue :"+puntuacionMasBaja);
        }
        public void Promedio()
        {
            float promedioPuntuaciones = 0;

            for (int i = 0; i < 6; i++) 
            {
                promedioPuntuaciones = promedioPuntuaciones + puntuacion[i];
            }
            promedioPuntuaciones =promedioPuntuaciones/puntuacion.Length ;
            Console.WriteLine(promedioPuntuaciones); 
        }
        public void VecesQueSuperoLas500() 
        {
            int puntuacionMayorA500 = 0;
            for(int i = 0;i < 6; i++) 
            {
                if (puntuacion[i] > 500)
                {
                    puntuacionMayorA500++;
                }
            }
            Console.WriteLine("Veces que supero los 500 puntos: " + puntuacionMayorA500);
        }
        static void Main(string[] args)
        {
                Puntuaciones p = new Puntuaciones();
                p.Carga();
                p.PuntuacionMasAltaYBaja();
                p.Promedio();
                p.VecesQueSuperoLas500();
                Console.ReadKey();
        }
    }
}
