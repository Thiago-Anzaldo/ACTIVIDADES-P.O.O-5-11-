using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoArcade ja = new JuegoArcade();

            if (ja.Partida() == true) 
            {
                Console.WriteLine("la primera partida rompio el record");
            }
            else
            {
                Console.WriteLine("la primera partida no rompio el record");
            }
            if (ja.Partida() == true)
            {
                Console.WriteLine("la segunda partida rompio el record");
            }
            else
            {
                Console.WriteLine("la segunda partida no rompio el record");
            }
            if (ja.Partida() == true)
            {
                Console.WriteLine("la tercera partida rompio el record");
            }
            else
            {
                Console.WriteLine("la tercera partida no rompio el record");
            }
            if (ja.Partida() == true)
            {
                Console.WriteLine("la cuarta partida rompio el record");
            }
            else 
            {
                Console.WriteLine("la cuarta partida no rompio el record");
            }
        }
    }
}
