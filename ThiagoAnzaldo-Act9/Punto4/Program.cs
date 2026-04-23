using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class EvaluacionDocentes
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)*/

        private string[] docentes;
        private int[] calificaciones;
        public void CargarDatos()
        {
            docentes = new string[6];
            calificaciones = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("nombre del docente: ");
                docentes[i] = Console.ReadLine();
                Console.Write("calificación del docente: ");
                calificaciones[i] = int.Parse(Console.ReadLine());
            }
        }

        public void MejorYPeorNota()
        {
            string docentePeorNota = "";
            string docenteMejorNota = "";
            int mejorNota = 0;
            int peorNota = calificaciones[0];

            for (int i = 0; i < docentes.Length; i++)
            {
                if (calificaciones[i] >= mejorNota)
                {
                    mejorNota = calificaciones[i];
                    docenteMejorNota += docentes[i]+" ";

                }
            }

                for (int i = 1; i < docentes.Length; i++)
                {
                    if (calificaciones[i] <= peorNota)
                    {
                        peorNota = calificaciones[i];
                        docentePeorNota += docentes[i]+" ";
                    }
                }

            Console.WriteLine("La mejor calificación es: " + mejorNota+ " y los que se la sacaron fueron: "+docenteMejorNota);
            Console.WriteLine("La peor calificación es: " + peorNota+" y los que se la sacaron fueron: "+docentePeorNota);
        }

        public void OrdenarDocentes()
        {
            int auxNotas = 0;
            string auxDocentes = "";

            for (int i = 0; i < docentes.Length - 1; i++)
            {
                for (int j = 0; j < docentes.Length - 1; j++)
                {
                    if (calificaciones[j] < calificaciones[j + 1])
                    {
                        auxNotas = calificaciones[j];
                        calificaciones[j] = calificaciones[j + 1];
                        calificaciones[j + 1] = auxNotas;

                        auxDocentes = docentes[j];
                        docentes[j] = docentes[j + 1];
                        docentes[j + 1] = auxDocentes;
                    }
                }
            }
            for (int i = 0; i < docentes.Length; i++)
            {
                Console.WriteLine(docentes[i] + " Nota sacada: " + calificaciones[i]);
            }
        }

        public void CantidadAprobadosDesaprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }
            Console.WriteLine("Cantidad de docentes aprobados: " + aprobados);
            Console.WriteLine("Cantidad de docentes desaprobados: " + desaprobados);
        }
        static void Main(string[] args)
        {
            EvaluacionDocentes ed = new EvaluacionDocentes();
            ed.CargarDatos();
            ed.MejorYPeorNota();
            ed.OrdenarDocentes();
            ed.CantidadAprobadosDesaprobados();
            Console.ReadKey();
        }
    }
}