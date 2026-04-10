using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    El valor acumulado de todos los elementos del vector.
    El valor acumulado de los elementos del vector que sean mayores a 36.
    Cantidad de valores mayores a 50.*/
    internal class Vector
    {
        private int[] valores;


        public void Carga()
        {
            valores = new int[8];

            for (int i = 0; i < 8; i++)
            {
                string linea;
                Console.Write("Ingrese un valor:  ");
                linea = Console.ReadLine();
                valores[i] = int.Parse(linea);
            }
        }
        public void SumaDeValores()
        {
            int valorAcumulado;
            valorAcumulado = 0;
            for (int i = 0; i < 8; i++)
            {
                valorAcumulado = valorAcumulado + valores[i];
            }
            Console.WriteLine("El valor acumulado es: " + valorAcumulado);
        }
        public void MayoresA36()
        {
            int valoresMayoresA36;
            valoresMayoresA36 = 0;
            for (int i = 0; i < 8; i++)
            {
                if (valores[i] > 36)
                {
                    valoresMayoresA36 = valoresMayoresA36 + valores[i];
                }
            }
            Console.WriteLine("acumulado de valores mayores a 36: " + valoresMayoresA36);
        }
        public void MayoresA50()
        {
            int valoresMayoresA50;
            valoresMayoresA50 = 0;

            for (int i = 0; i < 8; i++)
            {
                if (valores[i] > 50)
                {
                    valoresMayoresA50++;
                }
            }
            Console.WriteLine("Cantidad mayores a 50: " + valoresMayoresA50);
        }
        static void Main(string[] args)
        {
            Vector v = new Vector();
            v.Carga();
            v.MayoresA36();
            v.SumaDeValores();
            v.MayoresA50();
            Console.ReadKey();
        }
    }
}

