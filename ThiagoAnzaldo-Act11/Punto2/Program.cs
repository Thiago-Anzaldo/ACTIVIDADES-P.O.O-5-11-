using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
//    2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
//      primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
//      (crearla sin la intervención del operador)
//      Realizar la carga por teclado e imprimir posteriormente.
    internal class Program
    {
        private int[][] matriz;
        public void Creacion() 
        {
            matriz = new int[5][];
            for (int i = 0; i < matriz.Length; i++) 
            {
                matriz[i] = new int [i+1];
            }
        }

        public void Carga() 
        {
            string linea;
            for (int i = 0; i < matriz.Length; i++) 
            {
                for (int j = 0; j < matriz[i].Length; j++) 
                {
                    Console.WriteLine("Ingrese datos ");
                    linea = Console.ReadLine();
                    matriz[i][j] = int.Parse(linea);
                }
            }
            Console.WriteLine("\n");
        }
        public void Muestra() 
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.Write((i+1)+"° fila: ");
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Creacion();
            p.Carga();
            p.Muestra();
            Console.ReadKey();
        }
    }
}
