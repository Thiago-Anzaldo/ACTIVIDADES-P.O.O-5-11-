using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        private string titulo;
        private string autor;
        private int cantPaginas;

        public Libro()
        {
            string linea;

            Console.Write("ingrese el titulo del libro: ");
            titulo = Console.ReadLine();

            Console.Write("ingrese el autor del libro: ");
            autor = Console.ReadLine();

            do
            {
                Console.Write("ingrese la cantidad de paginas del libro: ");
                linea = Console.ReadLine();
                cantPaginas = int.Parse(linea);
            } while (cantPaginas <= 10);
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }
        public string Autor 
        {
            get 
            {  
                return autor;
            }
        }
        public int CantPaginas 
        {
            get 
            {
                return cantPaginas;
            }
        }
    }
}
