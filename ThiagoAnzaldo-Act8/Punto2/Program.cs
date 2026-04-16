using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Paises
    {
        /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
        algoritmo de ordenamiento alfabético.*/

        private string[] paises;

        public void CargaPaises() 
        {
            paises = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un pais: ");
                paises[i] = Console.ReadLine();
            }
        }
        public void OrdenAlfabetico() 
        {
            string aux=paises[0];
            for (int i = 0; i < 4; i++) 
            {
                for(int j = 0; j < 4; j++) 
                {
                    if (paises[j].CompareTo(paises[j+1]) > 0) 
                    {
                        aux=paises[j];
                        paises[j] = paises[j + 1];
                        paises[j+1]=aux;
                    }
                }
            }
        }
        public void Muestra() 
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(paises[i]);
            }
        }
        static void Main(string[] args)
        {
            Paises p = new Paises();
            p.CargaPaises();
            p.OrdenAlfabetico();
            p.Muestra();

            Console.ReadKey();
        }
    }
}
