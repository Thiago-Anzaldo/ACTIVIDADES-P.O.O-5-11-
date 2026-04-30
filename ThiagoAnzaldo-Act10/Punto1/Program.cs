using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Matriz1
    {
        /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.*/

        private int[,] matriz;

        public void Carga() 
        {
            matriz = new int[2, 5];
            string linea;

            for (int i=0; i < matriz.GetLength(1);i++) 
            {
                for(int j=0; j < matriz.GetLength(0); j++) 
                {
                    Console.Write("Ingrese un componente: ");
                    linea =Console.ReadLine();
                    matriz[j,i] = int.Parse(linea);
                }
            }
        }
        public void Muestra() 
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] +" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Matriz1 matriz = new Matriz1();
            matriz.Carga();
            matriz.Muestra();
            Console.ReadKey();
        }
    }
}
