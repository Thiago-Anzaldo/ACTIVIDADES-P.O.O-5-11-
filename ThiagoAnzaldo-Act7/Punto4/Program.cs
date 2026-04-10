using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    ordenado de menor a mayor y de mayor a menor.*/
    internal class MayoresYMenores
    {
        private int[] vector;

        public void Carga()
        {
            string linea;
            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("ingresa los valores del vector: ");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }
        public void MayorAMenor() 
        {
            bool ordenadoMayorAMenor = true;
            int auxiliar = vector[0];
            for (int i = 0; i < 10; i++) 
            {
                if (vector[i] <= auxiliar)
                {
                    auxiliar = vector[i];
                }
                else 
                {
                    ordenadoMayorAMenor = false;
                }
            }
            if (ordenadoMayorAMenor == false)
            {
                Console.WriteLine("No esta ordenado de mayor a menor");
            }
            else 
            {
                Console.WriteLine("esta ordenado de mayor a menor");
            }
        }
        public void MenorAMayor()
        {
            bool ordenadoMenorAMayor = true;
            int auxiliar = vector[0];
            for (int i = 0; i < 10; i++)
            {
                if (vector[i] >= auxiliar)
                {
                    auxiliar = vector[i];
                }
                else
                {
                    ordenadoMenorAMayor = false;
                }
            }
            if (ordenadoMenorAMayor == false)
            {
                Console.WriteLine("No esta ordenado de menor a mayor");
            }
            else 
            {
                Console.WriteLine("esta ordenado de menor a mayor");
            }
        }
        static void Main(string[] args)
        {
            MayoresYMenores mm=new MayoresYMenores();
            mm.Carga();
            mm.MayorAMenor();
            mm.MenorAMayor();
            Console.ReadKey();
        }
    }
}
