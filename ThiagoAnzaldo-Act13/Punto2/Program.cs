using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Implementar la clase operaciones.Se deben cargar dos valores enteros en el
    //constructor, calcular su suma, resta, multiplicación y división, cada una en un
    //método, imprimir dichos resultados.
    class Operaciones
    {
        private int valor1, valor2, suma, resta , multiplicacion;
        private double division;
        public Operaciones() 
        {
            string linea;

            Console.Write("Ingrese un valor: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.Write("ingrese el segundo valor");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void Suma() 
        {
            suma = valor1 + valor2;
        }

        public void Resta()
        {
            resta = valor1 - valor2;
        }
        public void Multiplicacion()
        {
            multiplicacion = valor1 * valor2;
        }
        public void Division()
        {
            division = valor1 / valor2;
        }

        public void ImprimirResultados() 
        {
            Console.WriteLine("resultado de la suma es: " + suma);
            Console.WriteLine("resultado de la resta es: " + resta);
            Console.WriteLine("resultado de la multiplicacion es: " + multiplicacion);
            Console.WriteLine("resultado de la division es: " + division);

        }
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.Suma();
            op.Resta();
            op.Multiplicacion();
            op.Division();
            op.ImprimirResultados();
            Console.ReadKey();
        }
    }
}