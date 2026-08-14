using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    //9-
    //Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
    //realizar el seguimiento académico de sus materias.
    // Crear la clase Estudiante que contenga como atributos privados:
    //nombreCompleto(string) y calificacion(double). Definir sus propiedades
    //de solo lectura y un constructor que reciba nom y cal.
    // Crear la clase GestionAcademica que administre una lista de objetos
    //List.
    // Métodos en GestionAcademica:
    //o CargarEstudiantes(): Solicitar por teclado nombres y
    //calificaciones para agregar estudiantes a la lista mediante.Add(). La
    //carga finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como
    //nombre.
    //o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
    //junto a la cantidad total de inscriptos mediante la propiedad .Count.
    //o FiltrarAprobados(): Recorrer la lista e imprimir en consola
    //únicamente aquellos estudiantes cuya calificación sea mayor o igual
    //a 6.0.
    //o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
    //utilizando los métodos de búsqueda y remoción de listas, eliminarlo
    //de la colección si se encuentra presente.
    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public Estudiante(string nom, double cal)
        {
            nombreCompleto = nom;
            calificacion = cal;
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }
        public double Calificacion
        {
            get { return calificacion; }
        }
    }

    internal class GestionAcademica
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        public void CargarEstudiante()
        {
            string linea;
            string nom;
            double cal;
            while (true)
            {
                Console.Write("ingrese el nombre del estudiante (ponga 'FIN' para finalizar la carga): ");
                nom = Console.ReadLine();

                if (nom == "FIN")
                {
                    break;
                }

                Console.Write("ingrese el calificacion del estudiante: ");
                linea = Console.ReadLine();
                cal = double.Parse(linea);

                estudiantes.Add(new Estudiante(nom, cal));
            }
        }
        public void ListarEstudiantes()
        {
            foreach (Estudiante est in estudiantes)
            {
                Console.WriteLine(est.NombreCompleto);
            }
            Console.WriteLine("la cantidad de estudiantes que hay es: " + estudiantes.Count());
        }

        public void FiltrarAprobados()
        {
            Console.WriteLine("los que aprobaron son: ");
            foreach (Estudiante est in estudiantes)
            {
                if (est.Calificacion > 6)
                {
                    Console.WriteLine(est.NombreCompleto);
                }
            }
        }
        public void DarDeBaja()
        {
            string alumnoEliminar;

            Console.Write("escriba el nombre del alumno que quiere eliminar: ");
            alumnoEliminar = Console.ReadLine();

            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].NombreCompleto == alumnoEliminar)
                {
                    estudiantes.Remove(estudiantes[i]);
                }
            }
            Console.WriteLine("nueva lista--------------------------------------");
            foreach (Estudiante est in estudiantes)
            {
                Console.WriteLine(est.NombreCompleto);
            }
        }
        static void Main(string[] args)
        {
            GestionAcademica ga = new GestionAcademica();
            ga.CargarEstudiante();
            ga.ListarEstudiantes();
            ga.FiltrarAprobados();
            ga.DarDeBaja();
        }
    }
}
