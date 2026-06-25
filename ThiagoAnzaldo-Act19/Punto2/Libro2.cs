using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("titulo: " + Titulo);
            Console.WriteLine("autor: " + Autor);
            if (CantPaginas < 100)
            {
                Console.WriteLine("cantidad de paginas : " + CantPaginas + ", el libro es corto");
            }
            else
            {
                Console.WriteLine("cantidad de paginas : " + CantPaginas + ", el libro es largo");
            }
        }
    }
}
