using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
    ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    nuevamente.*/
    internal class paisesYHabitantes
    {
        private int[] habitantes;
        private string[] paises;

        public void Carga() 
        {
            string linea;
            habitantes = new int[5];
            paises = new string[5];

            for (int i = 0; i < paises.Length; i++) 
            {
                Console.Write("Ingrese un pais: ");
                paises[i] = Console.ReadLine();

                Console.Write("Ingrese la cantidad de habitantes: ");
                linea = Console.ReadLine();
                habitantes[i]=int.Parse(linea);
            }
        }
        public void OrdenamientoPaises() 
        {
            string auxPaises = paises[0];
            int auxHab=habitantes[0];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (paises[j].CompareTo(paises[j + 1]) > 0)
                    {
                        auxPaises = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxPaises;

                        auxHab = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxHab;
                    }
                }
            }
        }
        public void OrdenamientoSegunHabitantes() 
        {
            string auxPaises = paises[0];
            int auxHab = habitantes[0];
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4; f++)
                {
                    if (habitantes[f] > habitantes[f + 1])
                    {
                        auxHab = habitantes[f];
                        habitantes[f] = habitantes[f + 1];
                        habitantes[f + 1] = auxHab;

                        auxPaises = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = auxPaises;
                    }
                }
            }
        }
        public void MuestraAlfabeticamente()
        {
            Console.WriteLine("Paises ordenados alfabeticamente: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(paises[i] +": "+ habitantes[i]);
            }
        }
        public void MuestraSegunHabitantes() 
        { 
            Console.WriteLine("Habitantes ordenados: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(habitantes[i] +": "+ paises[i]);
            }
        }
        static void Main(string[] args)
        {
            paisesYHabitantes ph=new paisesYHabitantes();
            ph.Carga();
            ph.OrdenamientoPaises();
            ph.MuestraAlfabeticamente();
            ph.OrdenamientoSegunHabitantes();
            ph.MuestraSegunHabitantes();

            Console.ReadKey();
        }
    }
}
