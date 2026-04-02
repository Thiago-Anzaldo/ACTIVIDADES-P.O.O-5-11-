using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Operaciones
    {
        /*4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
        calcular su suma, resta, multiplicación y división, cada una en un método,
        imprimir dichos resultados.*/
        private int valor1,valor2, suma, resta, multiplicacion, division;

        public void CargaDeValores()
        {
            string linea;
            Console.Write("Escriba el valor de un numero: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);
            Console.Write("Escriba el valor de otro numero: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }
        public void Suma()
        {
            suma = valor1 + valor2;
            Console.WriteLine("La suma de los numeros es: " + suma);
        }
        public void Resta()
        {
            resta = valor1 - valor2;
            Console.WriteLine("La resta de los numeros es: " + resta);
        }
        public void Multiplicacion()
        {
            multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicacion de los numeros es: " + multiplicacion);
        }
        public void Division()
        {
            division = valor1 / valor2;
            Console.WriteLine("La divion de los numeros es: " + division);
        }

        static void Main(string[] args)
        {
            Operaciones op1 = new Operaciones();
            op1.CargaDeValores();
            op1.Suma();
            op1.Resta();
            op1.Multiplicacion();
            op1.Division();
            Console.ReadKey();
        }

    }
}