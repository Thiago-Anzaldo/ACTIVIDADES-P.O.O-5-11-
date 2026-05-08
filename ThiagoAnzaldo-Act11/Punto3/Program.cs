using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
//    3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
//      empresa.
//      Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
//      irregular para cargar los días que han faltado cada empleado (cargar el número de día que
//      faltó)
//      Cada fila de la matriz representa los días de cada empleado.
//      a.Mostrar los empleados con la cantidad de inasistencias.
//      b.Cuál empleado faltó menos días.
    internal class Inasistencias
    {
        private string[] empleados;
        private int[][] inasistencias;

        public void Carga()
        {
            empleados = new string[3];
            inasistencias = new int[3][];
            int cantidadFaltas = 0;
            string linea;

            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("Escriba el nombre del empleado: ");
                empleados[i] = Console.ReadLine();

                Console.WriteLine("Cuantos dias falto?");
                linea = Console.ReadLine();
                cantidadFaltas = int.Parse(linea);

                inasistencias[i] = new int[cantidadFaltas];

                for (int j = 0; j < cantidadFaltas; j++)
                {
                    Console.WriteLine("Que dias falto?");
                    linea = Console.ReadLine();
                    inasistencias[i][j] = int.Parse(linea);
                }
            }
            Console.WriteLine("\n");
        }
        public void Muestra() { 
            for(int i = 0; i < empleados.Length; i++) 
            {
                Console.WriteLine("el empleado " + empleados[i] + " falto los dias: ");
                for (int j = 0; j < inasistencias[i].Length; j++)
                {
                    Console.Write(inasistencias[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
        }
        
        public void MenorInasistencias() 
        {
            int mayorFaltas = inasistencias[0][0];
            string empMasFaltas="";
            for (int i = 0; i < empleados.Length; i++) 
            {
                if (inasistencias[i].Length < mayorFaltas) 
                {
                    mayorFaltas = inasistencias[i].Length;
                    empMasFaltas = empleados[i];
                }
            }
            Console.WriteLine("el empleado "+empMasFaltas+" es el que tiene la mayor cantidad de faltas con: "+mayorFaltas);
        }
        static void Main(string[] args)
        {
            Inasistencias ina = new Inasistencias();
            ina.Carga();
            ina.Muestra();
            ina.MenorInasistencias();
            Console.ReadKey();
        }
    }
}
