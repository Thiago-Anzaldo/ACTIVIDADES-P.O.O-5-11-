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
            for (int i = 0; i < 5; i++) 
            {
                for(int j = 0; j < 5; j++) 
                {
                
                }
            }
        }
        static void Main(string[] args)
        {
            Paises paises = new Paises();
            paises.CargaPaises();
        }
    }
}
