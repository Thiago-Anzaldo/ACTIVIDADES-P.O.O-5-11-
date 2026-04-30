using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Matriz2
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
        primer fila con la segunda. Imprimir luego la matriz.*/
        private int[,] matriz;

        public void Carga() 
        {
            string linea;
            int filas = 0;
            int columna = 0;

            do { 
            Console.WriteLine("Ingrese la cantidad de filas (Mayor a 1): ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);
            }
            while (filas < 2) ;

            Console.WriteLine("Ingrese la cantidad de columnas: ");
            linea=Console.ReadLine();
            columna = int.Parse(linea);

            matriz = new int[filas, columna];
        }

        public void Cambio1a2() 
        { 
             
        }
        static void Main(string[] args)
        {
            Matriz2 m2=new Matriz2();
            m2.Carga();
        }
    }
}
