using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    //6-
    //Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    //para organizar la consulta de ejemplares por parte de los lectores.
    // Crear la clase Libro que contenga como atributos privados: titulo
    //(string) y anioPublicacion(int). Definir sus propiedades de solo lectura y
    //un constructor que reciba tit y anio.
    // Crear la clase BibliotecaCentral que administre una lista de objetos
    //List.
    // Métodos en BibliotecaCentral:
    //1. CargarCatalogo(): Solicitar por teclado títulos y años de
    //publicación para agregar libros a la lista mediante.Add(). La carga
    //finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como título.
    //2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    //junto a la cantidad total de obras registradas mediante la propiedad
    //.Count.
    //3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
    //imprimir en consola únicamente aquellos libros cuyo año de
    //publicación sea menor a dicho valor.
    //4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    //los métodos de búsqueda y remoción de listas, eliminarlo de la
    //colección si se encuentra presente.
    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public Libro(string tit, int anio)
        {
            titulo = tit;
            anioPublicacion = anio;
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }
        public string Titulo
        {
            get { return titulo; }
        }
    }
    internal class BibliotecaCentral
    {
        List<Libro> libros = new List<Libro>();

        public void CargarCatologo()
        {
            string tit;
            int anio;
            string linea;
            while (true)
            {
                do
                {
                    Console.WriteLine("ingrese el titulo del libro: ");
                    tit = Console.ReadLine();
                } while (tit == "");

                if (tit == "FIN") 
                {
                    break;
                }
                do
                {
                    Console.WriteLine("ingrese el año de publicacion: ");
                    linea = Console.ReadLine();
                } while (linea == "");
                anio = int.Parse(linea);
                libros.Add(new Libro(tit, anio));
            }
        }
        public void ListarCatalogo() 
        {
            foreach(Libro li in libros) 
            {
                Console.Write("titulo: "+li.Titulo+" ");
                Console.WriteLine("año de publicacion "+li.AnioPublicacion);
            }
                Console.WriteLine("total de libros "+libros.Count);
        }
        public void FiltrarPorAnio() 
        {
            string opcion;
            int año;

            Console.WriteLine("ingrese el año para filtrar: ");
            opcion=Console.ReadLine();
            año=int.Parse(opcion);

            foreach (Libro li in libros) 
            {
                if (li.AnioPublicacion<año) 
                {
                    Console.Write(li.Titulo+" ");
                    Console.WriteLine(" "+li.AnioPublicacion);
                }
            }
        }
        public void RemoverLibro() 
        {
            string tituloBorrar;

            Console.WriteLine("escriba un titulo de libro para borrar: ");
            tituloBorrar=Console.ReadLine();

            Libro libroEncontrado = libros.Find(x => x.Titulo == tituloBorrar);

            if (libroEncontrado != null)
            {
                libros.Remove(libroEncontrado);
                Console.WriteLine("libro encontrado");
            }
            else
            {
                Console.WriteLine("no se encontro ningun libro");
            }
        }
        static void Main(string[] args)
        {
            BibliotecaCentral bc=new BibliotecaCentral();
            bc.CargarCatologo();
            bc.ListarCatalogo();
            bc.FiltrarPorAnio();
            bc.RemoverLibro();
        }
    }
}
