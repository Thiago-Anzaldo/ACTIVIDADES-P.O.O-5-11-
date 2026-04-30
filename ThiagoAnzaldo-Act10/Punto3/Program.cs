using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Punto3
{
    internal class Matriz3
    {
        /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)*/
        private int[,] matriz;

        public void Carga()
        {
            string linea;
            int columna = 0;
            int filas = 0;
            do
            {
                Console.WriteLine("Ingrese la cantidad de filas (Mayor a 1): ");
                linea = Console.ReadLine();
                filas = int.Parse(linea);
            }
            while (filas < 2);

            Console.WriteLine("Ingrese la cantidad de columnas: ");
            linea = Console.ReadLine();
            columna = int.Parse(linea);

            matriz = new int[filas, columna];

            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Ingrese un componente: ");
                    linea = Console.ReadLine();
                    matriz[i, j] = int.Parse(linea);
                }
            }
        }
        public void Muestra()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Vertices() { 
            Console.Write("Primer vertice: " + matriz[0, 0]);
            Console.WriteLine();
            Console.Write("segundo vertice: " + matriz[0, matriz.GetLength(1)-1]);
            Console.WriteLine();
            Console.Write("tercero vertice: " + matriz[matriz.GetLength(0)-1, 0]);
            Console.WriteLine();
            Console.Write("cuarto vertice: " + matriz[matriz.GetLength(0) - 1, matriz.GetLength(1)-1]);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Matriz3 matriz = new Matriz3();
            matriz.Carga();
            matriz.Muestra();
            matriz.Vertices();
            Console.ReadKey();
        }
    }
}
