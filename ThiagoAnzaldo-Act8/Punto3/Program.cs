using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Ordenamiento
    {
        /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        (el orden lo pueden elegir ustedes).*/
        private int[] vector;

        public void Carga()
        {
            string linea;
            vector = new int[5];
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese los valores del vector: ");
                linea = Console.ReadLine()!;
                vector[i] = int.Parse(linea);
            }
        }
        public void Ordenar()
        {
            int aux = vector[0];
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 ; f++)
                {
                    if (vector[f] > vector[f + 1])
                    {
                        aux = vector[f];
                        vector[f] = vector[f + 1];
                        vector[f + 1] = aux;
                    }
                }
            }
        }
        public void Muestra() 
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void Main(string[] args)
        {
            Ordenamiento o = new Ordenamiento();
            o.Carga();
            o.Ordenar();
            o.Muestra();
            Console.ReadKey();
        }
    }
}
