using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Cuadrante
    {
        /*1. Desarrollar una clase que represente un punto en el plano y tenga los
            siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
            encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
            positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)*/
        private int x, y;

        public void CargaDeValores()
        {
            string linea;
            Console.Write("ingrese el valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            Console.Write("ingrese el valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);
        }
        public void MuestraDeValores()
        {

        }
        static void Main(string[] args)
        {
            Cuadrante cua = new Cuadrante();
            cua.CargaDeValores();
            cua.MuestraDeValores();
            Console.ReadKey();
        }

    }
}