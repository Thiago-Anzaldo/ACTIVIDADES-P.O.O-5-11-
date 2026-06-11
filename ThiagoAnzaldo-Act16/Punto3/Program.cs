using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    //3. Crear una clase base Vehículo que contenga atributos marca y
    //velocidadMaxima.
    //Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
    //una debe tener un constructor que reciba los valores de los atributos base
    //mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    //Auto, cilindrada en Moto).
    //Crear un objeto de cada clase y mostrar todos sus datos por consola.

    public class Vehiculo
    {
        private string marca;
        private string velocidadMaxima;

        public string Marca 
        {
            set 
            { 
                marca = value; 
            }
            get 
            {
                return marca;
            }
        }
        public string Velocidad
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }
    }

    public class Auto : Vehiculo 
    {
        private Vehiculo baseAuto;
        private string cantidadPuertas;
        public Auto()
        {
            baseAuto = new Vehiculo();

            Console.WriteLine("Cual es la marca de auto: ");
            baseAuto.Marca = Console.ReadLine();

            Console.WriteLine("Cual es la velocidad maxima: ");
            baseAuto.Velocidad = Console.ReadLine();

            Console.WriteLine("cantidad de puertas: ");
            cantidadPuertas = Console.ReadLine();
        }

        public void MuestraAuto() 
        {
            Console.WriteLine("Marca de la auto: " + baseAuto.Marca);
            Console.WriteLine("Velocidad de la auto: " + baseAuto.Velocidad);
            Console.WriteLine("su cilindrada: " + cantidadPuertas);
        }
    }

    public class Moto : Vehiculo
    {
        private Vehiculo baseMoto;
        private string cilindrada;
        public Moto() 
        {
            baseMoto = new Vehiculo();

            Console.WriteLine("Cual es la marca de moto: ");
            baseMoto.Marca = Console.ReadLine();

            Console.WriteLine("Cual es la velocidad maxima: ");
            baseMoto.Velocidad = Console.ReadLine();

            Console.WriteLine("cilindrada: ");
            cilindrada = Console.ReadLine();
        }
        public void MuestraMoto() 
        {

            Console.WriteLine("Marca de la moto: "+baseMoto.Marca);
            Console.WriteLine("Velocidad de la moto: "+baseMoto.Velocidad);
            Console.WriteLine("su cilindrada: "+cilindrada);
        }
    }
        class prueba
    {
        static void Main(string[] args)
        {
            Auto a = new Auto();

            Moto m = new Moto();
            m.MuestraMoto();
            a.MuestraAuto();
            Console.ReadKey();
        }
    }
}