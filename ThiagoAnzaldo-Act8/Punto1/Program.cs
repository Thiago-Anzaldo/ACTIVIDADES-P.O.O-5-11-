using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class ElementoMenor
    {
        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
        del vector.*/
        private int[] vector;

        public void Carga() 
        {
            int cantidadElementos = 0;
            string linea;
            Console.Write("Ingrese el tamaño de vector: ");
            linea = Console.ReadLine();
            cantidadElementos=int.Parse(linea);

            vector = new int[cantidadElementos];
        }
        public void Menor() 
        {
            int menor = 0;
            string linea;
            Console.WriteLine("AHORA INGRESE LOS ELEMENTOS DEL VECTOR \n");

            for (int i = 0; i < vector.Length; i++)
            {
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
                if (menor == vector[i])
                {
                    Console.WriteLine("--SE REPITE--");
                }
                if (i == 0)
                {
                    menor = vector[0];
                }

                if (menor > vector[i])
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine("Finaliza el programa");
        }
        static void Main(string[] args)
        {
            ElementoMenor p=new ElementoMenor();
            p.Carga();
            p.Menor();
            Console.ReadKey();
        }
    }
}
