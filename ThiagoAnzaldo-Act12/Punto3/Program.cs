using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Punto3
{
    //    3. Academia de Gastronomía: Recetario Dinámico
    //      Un chef instructor evalúa a 3 alumnos en un examen final.Cada alumno debe presentar
    //      una cantidad distinta de platos(uno presenta 2 platos, otro 4 y otro 3).
    //          ● Definir un vector para los nombres de los alumnos.
    //          ● Definir una matriz irregular para cargar el puntaje obtenido(0 a 100) en cada plato
    //          presentado.
    //          ● Métodos:
    //              1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
    //              de cada alumno.
    //              2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
    //              3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
    //              4. Calcular el puntaje promedio de cada alumno e informar si está &quot; Aprobado&quot;
    //              (promedio &gt;= 70) o &quot;Reprobado&quot;.
    //              5. Determinar quién obtuvo el puntaje individual más alto en un solo plato(el
    //              valor máximo de la matriz).
    internal class AcademiaGastronomia
    {
        private double[] promediosAlumnos;
        private string[] nombreAlumnos;
        private int[][] calificacionPlatos;

        public void Carga()
        {
            calificacionPlatos = new int[3][];
            nombreAlumnos = new string[3];
            string linea;

            Console.Write("Nombre del alumno que va presentar 2 platos: ");
            nombreAlumnos[0] = Console.ReadLine();
            calificacionPlatos[0] = new int[2];

            Console.Write("Nombre del alumno que va presentar 3 platos: ");
            nombreAlumnos[1] = Console.ReadLine();
            calificacionPlatos[1] = new int[3];

            Console.Write("Nombre del alumno que va presentar 4 platos: ");
            nombreAlumnos[2] = Console.ReadLine();
            calificacionPlatos[2] = new int[4];

            Console.WriteLine();
        }

        public void Puntaje()
        {
            int puntajePlato = 0;
            string linea;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < calificacionPlatos[i].Length; j++)
                {
                    do
                    {
                        Console.Write("Ingrese una calificacion del 1 al 100 en el plato N°" + (j + 1) + " del alumno " + nombreAlumnos[i] + ": ");
                        linea = Console.ReadLine();
                        puntajePlato = int.Parse(linea);
                    }
                    while (puntajePlato < 0 || puntajePlato > 100);
                    calificacionPlatos[i][j] = int.Parse(linea);
                }
                Console.WriteLine();
            }
        }

        public void MuestraDeAlumnos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Alumno " + nombreAlumnos[i]);

                for (int j = 0; j < calificacionPlatos[i].Length; j++)
                {
                    Console.WriteLine("plato N°"+(j+1)+" puntuacion: " + calificacionPlatos[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void promedioPuntajes()
        {
            promediosAlumnos = new double [3];
            double promedioPuntajes = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < calificacionPlatos[i].Length; j++)
                {
                    promedioPuntajes = promedioPuntajes + calificacionPlatos[i][j];
                }

                promedioPuntajes = promedioPuntajes / calificacionPlatos[i].Length;

                Console.WriteLine("El alumno " + nombreAlumnos[i] + " tiene un promedio de: " + promedioPuntajes);
                if (promedioPuntajes >= 70)
                {
                    Console.WriteLine("Alumno aprobado!!");
                }
                else 
                {
                    Console.WriteLine("Alumno reprobado");
                }
                Console.WriteLine();
                promediosAlumnos[i] = promedioPuntajes;
                promedioPuntajes = 0;
            }
        }

        public void PuntuajeIndividualMasAlto()
        {
            string alumnoPuntajeMasAlto="";
            double promedioMasAlto = 0;
            for (int i = 0; i < 3; i++)
            {
                if (promediosAlumnos[i] > promedioMasAlto) 
                {
                    promedioMasAlto = promediosAlumnos[i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (promediosAlumnos[i] >= promedioMasAlto)
                {
                    alumnoPuntajeMasAlto += nombreAlumnos[i] + " ";
                }
            }

            Console.WriteLine("El/los alumno con el promedio mas alto es/son "+alumnoPuntajeMasAlto+"con "+promedioMasAlto);
        }
        static void Main(string[] args)
        {
            AcademiaGastronomia ac = new AcademiaGastronomia();
            ac.Carga();
            ac.Puntaje();
            ac.MuestraDeAlumnos();
            ac.promedioPuntajes();
            ac.PuntuajeIndividualMasAlto();
            Console.ReadKey();
        }
    }
}