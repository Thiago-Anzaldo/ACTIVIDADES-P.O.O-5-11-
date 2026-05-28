using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Alumno
    {

        private string nombre;
        private int[] calificaciones;

        public Alumno()
        {
            nombre = "";
            calificaciones = new int[3];
            string linea;
            Console.Write("Ingrese un nombre: ");
            linea = Console.ReadLine();
            nombre = linea;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("Ingrese la calificación " + (i + 1) + ": ");
                linea = Console.ReadLine();
                calificaciones[i] = int.Parse(linea);
            }
        }

        public string nombreAlumno()
        {
            return nombre;
        }

        public double promedioCalificaciones()
        {
            double promedio = 0;
            for (int i = 0; i < calificaciones.Length; i++)
            {
                promedio += calificaciones[i];
            }

            promedio = promedio / calificaciones.Length;
            return promedio;
        }
    }

    class Curso
    {
        private Alumno alumno1, alumno2, alumno3;
        public Curso()
        {
            alumno1 = new Alumno();
            alumno2 = new Alumno();
            alumno3 = new Alumno();
        }

        public void muestraAlumno() 
        {
            Console.WriteLine("Nombre alumno "+ alumno1.nombreAlumno());
            Console.WriteLine("Promedio: " + alumno1.promedioCalificaciones());
            Console.WriteLine();

            Console.WriteLine("Nombre alumno " + alumno2.nombreAlumno());
            Console.WriteLine("Promedio: " + alumno2.promedioCalificaciones());
            Console.WriteLine();

            Console.WriteLine("Nombre alumno " + alumno3.nombreAlumno());
            Console.WriteLine("Promedio: " + alumno3.promedioCalificaciones());
            Console.WriteLine();
        }
        public void promedioMayor()
        {
            string nombreMayor = alumno1.nombreAlumno();
            double promedioMayor = alumno1.promedioCalificaciones();
            if (alumno2.promedioCalificaciones() > promedioMayor)
            {
                nombreMayor = alumno2.nombreAlumno();
                promedioMayor = alumno2.promedioCalificaciones();
            }
            if (alumno3.promedioCalificaciones() > promedioMayor)
            {
                nombreMayor = alumno3.nombreAlumno();
                promedioMayor = alumno3.promedioCalificaciones();
            }
            Console.WriteLine("El alumno con el mayor promedio es: " + nombreMayor + " con un promedio de: " + promedioMayor);
            Console.WriteLine();
        }
        public void notaDesaprobada() 
        {
            if (alumno1.promedioCalificaciones() < 6)
            {
                Console.WriteLine("El alumno " + alumno1.nombreAlumno() + " esta desaprobado");
            }
            if (alumno2.promedioCalificaciones() < 6)
            {
                Console.WriteLine("El alumno " + alumno2.nombreAlumno() + " esta desaprobado");
            }
            if (alumno3.promedioCalificaciones() < 6)
            {
                Console.WriteLine("El alumno " + alumno3.nombreAlumno() + " esta desaprobado");
            }
        }
        static void Main(string[] args)
        {

            Curso c = new Curso();

            c.muestraAlumno();
            c.promedioMayor();
            c.notaDesaprobada();

            Console.ReadKey();
        }
    }

}