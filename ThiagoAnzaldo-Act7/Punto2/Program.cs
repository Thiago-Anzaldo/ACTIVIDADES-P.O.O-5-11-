using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    tercer vector del mismo tamaño. Sumar componente a componente.*/
    internal class SumaEntreVectores
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void Carga()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            for (int i = 0; i < 4; i++) 
            { 
            string linea;
            Console.Write("Ingrese un valor para el vector 1: ");
            linea = Console.ReadLine();
            vector1[i] = int.Parse(linea);
            Console.Write("Ingrese un valor para el vector 2: ");
            linea = Console.ReadLine();
            vector2[i] = int.Parse(linea);
            }
        }
        public void Suma()
        {
            vector3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                vector3[i] = vector2[i] + vector1[i];
            }
        }
        public void Muestra() 
        {
            for(int i = 0;i < 4; i++) 
            {
                Console.Write(" posicion "+i+": "+vector1[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" posicion " + i + ": "+vector2[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(" posicion " + i + ": " + vector3[i]);
            }
        }
        static void Main(string[] args)
        {
            SumaEntreVectores sev=new SumaEntreVectores();
            sev.Carga();
            sev.Suma();
            sev.Muestra();
            Console.ReadKey();
        }
    }
}
