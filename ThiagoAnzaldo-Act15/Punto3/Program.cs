using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Punto3
{
//    3. Geolocalización de Reservas Naturales
//Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
//especies protegidas en cuadrículas de territorio.
//● Confeccionar la clase ReservaNatural que tenga como atributos privados el
//NombreReserva y una matriz llamada avistamientos de 3x3(que representa un
//mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
//cantidad de animales avistados en cada sector). El constructor de la clase debe
//cargar por teclado el nombre y rellenar el mapa de avistamientos.
//● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
//objetos de la clase ReservaNatural.
//La clase CentroEcologico debe implementar los siguientes métodos:
//1. Un constructor que solicite la carga secuencial de las 3 reservas.
//2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
//registró en toda su superficie(la suma de toda su matriz rectangular).
//3. Un método que determine e informe cuál fue la coordenada o sector específico([fila,
//columna]) que registró la mayor concentración de avistamientos de toda la red de
//reservas, indicando a qué reserva pertenece.
    class ReservaNatural 
    {
        private string NombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            string linea;
            avistamientos = new int[3, 3];
            Console.Write("Ingrese el nombre de la reserva natural: ");
            NombreReserva = Console.ReadLine();

            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Sector [Fila " + k + ", Columna " + i + "]: ");
                    linea = Console.ReadLine();
                    avistamientos[k, i] = int.Parse(linea);
                }
            }
        }

        public string nombreReserva()
        {
            return NombreReserva;
        }
        public int matrizAvistamientos(int fila, int columna) 
        {
            return avistamientos[fila, columna];
        }
    }
    class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];
            for (int d = 0; d < 3; d++)
            {
                reservas[d] = new ReservaNatural();
            }
        }

        public void totalAvistamientos()
        {
            for (int d = 0; d < 3; d++)
            {
                int sumaAvistamientos = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sumaAvistamientos += reservas[d].matrizAvistamientos(i, j);
                    }
                }

                Console.WriteLine("La reserva " + reservas[d].nombreReserva() + " registro un total de: " + sumaAvistamientos + " animales.");
            }
            Console.WriteLine("\n");
        }

        public void sectorMayorConcentracion()
        {
            int maximoAvistamientos = 0;
            int filaMax = 0;
            int columnaMax = 0;
            string reservaMax = "";

            for (int d = 0; d < 3; d++)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (reservas[d].matrizAvistamientos(i, j) > maximoAvistamientos)
                        {
                            maximoAvistamientos = reservas[d].matrizAvistamientos(i, j);
                            filaMax = i;
                            columnaMax = j;
                            reservaMax = reservas[d].nombreReserva();
                        }
                    }
                }
            }
            Console.WriteLine("La reserva con el sector mas alto es: " + reservaMax);
            Console.WriteLine("Coordenada: Fila " + filaMax + ", Columna " + columnaMax);
            Console.WriteLine("Cantidad: " + maximoAvistamientos);
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            CentroEcologico c = new CentroEcologico();
            c.totalAvistamientos();
            c.sectorMayorConcentracion();
            Console.ReadKey();
        }
    }
}
