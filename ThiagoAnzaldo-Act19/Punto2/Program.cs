using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
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
        }
    }
}
