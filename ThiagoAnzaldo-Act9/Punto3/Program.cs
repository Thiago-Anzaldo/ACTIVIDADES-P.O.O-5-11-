using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Carrera
    {
        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.*/

        private string[] corredores;
        private int[] tiempos;

        public void CargarDatos()
        {
            corredores = new string[5];
            tiempos = new int[5];
            for (int i = 0; i < corredores.Length; i++)
            {
                Console.Write("Ingrese el nombre del atleta " + (i + 1) + ": ");
                corredores[i] = Console.ReadLine();
                Console.Write("Ingrese el tiempo del atleta " + corredores[i] + " en segundos:");
                tiempos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Promedio()
        {
            int sumaTiempos = 0;
            int promedioTiempo = 0;

            for (int i = 0; i < corredores.Length; i++)
            {
                sumaTiempos += tiempos[i];
            }

            promedioTiempo = sumaTiempos / corredores.Length;

            Console.WriteLine("El promedio de tiempos es: " + promedioTiempo);
        }

        public void MejorPeorTiempo()
        {
            int mejorTiempo = tiempos[0];
            int peorTiempo = tiempos[0];
            string nombreMejorAtleta = corredores[0];
            string nombrePeorAtleta = corredores[0];
            for (int i = 1; i < corredores.Length; i++)
            {
                if (tiempos[i] < mejorTiempo)
                {
                    mejorTiempo = tiempos[i];
                    nombreMejorAtleta = corredores[i];
                }
                if (tiempos[i] > peorTiempo)
                {
                    peorTiempo = tiempos[i];
                    nombrePeorAtleta = corredores[i];
                }
            }
            Console.WriteLine("El atleta con el mejor tiempo es: " + nombreMejorAtleta + " con un tiempo de " + mejorTiempo + " segundos.");
            Console.WriteLine("El atleta con el peor tiempo es: " + nombrePeorAtleta + " con un tiempo de " + peorTiempo + " segundos.");
        }
        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.CargarDatos();
            c.Promedio();
            c.MejorPeorTiempo();
            Console.ReadKey();
        }
    }
}