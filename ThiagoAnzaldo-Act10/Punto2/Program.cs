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

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write("Ingrese un componente: ");
                    linea = Console.ReadLine();
                    matriz[i, j] = int.Parse(linea);
                }
            }
        }

        public void Cambio1a2() 
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int temp = matriz[0, j];
                matriz[0, j] = matriz[1, j];
                matriz[1, j] = temp;
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
        static void Main(string[] args)
        {
            Matriz2 m2=new Matriz2();
            m2.Carga();
            m2.Cambio1a2();
            m2.Muestra();
            Console.ReadKey();
        }
    }
}
