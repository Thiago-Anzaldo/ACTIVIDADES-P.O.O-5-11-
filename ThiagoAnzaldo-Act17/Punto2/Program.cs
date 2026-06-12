using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Catálogo de Películas(Encapsulación, Validación y Composición)
    //Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
    //La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
    //(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
    //asegurando mediante validaciones lógicas que:
    // La duración en minutos sea estrictamente mayor a cero(0).
    // La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
    //un valor por defecto de 1).
    //La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
    //la clase Pelicula.Definir un método dentro de Catalogo para mostrar por pantalla todas las
    //películas ordenadas de mayor a menor en base a su duración.Además, el método debe
    //informar el título de la película con mejor calificación y cuál es la película más corta del
    //catálogo.

    class Pelicula 
    {
        private string Titulo;
        private int DuracionMinutos;
        private int Calificacion;

        public Pelicula() 
        {
            string linea;
            Console.Write("Titulo de la pelicula: ");
            Titulo = Console.ReadLine();

            do { 
            Console.Write("Duracion de la pelicula (minutos): ");
            linea = Console.ReadLine();
            DuracionMinutos=int.Parse(linea);
            }
            while (DuracionMinutos<1);

            Console.Write("Su puntuacion del 1 al 5: ");
            linea= Console.ReadLine();
            Calificacion = int.Parse(linea);

            if (Calificacion<1 || Calificacion>5) 
            {
                Calificacion = 1;
            }
        }

        public string ObtenerTitulo 
        {
            get { return Titulo; }
        }

        public int ObtenerDuracionMinutos
        {
            get { return DuracionMinutos; }
        }

        public int ObtenerCalificacion
        {
            get { return Calificacion; }
        }
    }
    class Catalogo
    {
        private Pelicula p1,p2,p3;
        private Pelicula[] peliculas;
        public Catalogo() 
        {
            p1 = new Pelicula();
            p2 = new Pelicula();
            p3 = new Pelicula();

            peliculas = new Pelicula[3];

            peliculas[0] = p1;
            peliculas[1] = p2;
            peliculas[2] = p3;
        }

        public void General() 
        {
            int c;
            int menorDuracion=peliculas[0].ObtenerDuracionMinutos;
            int peliculaMayorCalificacion= peliculas[0].ObtenerCalificacion;
            string tituloMayorCalificacion = "";

            Array.Sort(peliculas, (a, b) => b.ObtenerDuracionMinutos.CompareTo(a.ObtenerDuracionMinutos));

            for (int i = 0; i < peliculas.Length; i++) 
            {
                if (peliculaMayorCalificacion < peliculas[i].ObtenerCalificacion) 
                {
                    peliculaMayorCalificacion = peliculas[i].ObtenerCalificacion;
                    tituloMayorCalificacion = peliculas[i].ObtenerTitulo;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("PELICULAS ORDENADAS");
            for (int t=0;t<3;t++) 
            {
                Console.WriteLine(peliculas[t].ObtenerTitulo);
            }
            Console.WriteLine("\n");
            Console.WriteLine("La pelicula con mayor calificacion es: "+tituloMayorCalificacion);
            Console.WriteLine("La pelicula mas corta es: "+ peliculas[2].ObtenerTitulo);

        }
        static void Main(string[] args)
        {
            Catalogo c=new Catalogo();
            c.General();
            Console.ReadKey();  
        }
    }
}
