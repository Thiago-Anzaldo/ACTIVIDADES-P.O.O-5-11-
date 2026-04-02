using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Cuadrado
    {
        /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.*/
        private int lado, superficie, perimetro;
        public void CargaDeValores()
        {
            string linea;

            Console.Write("Escriba el valor de un lado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }
        public void muestraDeSuperficie()
        {
            superficie = lado * lado;
            Console.WriteLine("La superficie es: " + superficie);
        }
        public void muestraDePerimetro()
        {
            perimetro = lado * 4;
            Console.WriteLine("El perimetro es: " + perimetro);
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.CargaDeValores();
            cuadrado1.muestraDeSuperficie();
            cuadrado1.muestraDePerimetro();
            Console.ReadKey();
        }

    }
}