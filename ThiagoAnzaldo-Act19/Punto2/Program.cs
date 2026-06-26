using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Crear una clase parcial Libro.
    //En el primer archivo, declarar las propiedades Título, Autor y Páginas.Validar que la
    //cantidad de páginas sea mayor a 10.Valores cargados desde consola
    //En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
    //si el libro es corto(menos de 100 páginas) o largo.
    //Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro l1 = new Libro();
            Libro l2 = new Libro();

            l1.Resumen();
            l2.Resumen();
            if (l1.CantPaginas>l2.CantPaginas) 
            {
                Console.WriteLine("el libro mas extenso es " + l1.Titulo);
            }
            if (l2.CantPaginas > l1.CantPaginas)
            {
                Console.WriteLine("el libro mas extenso es " + l2.Titulo);
            }
            Console.ReadKey();
        }
    }
}
