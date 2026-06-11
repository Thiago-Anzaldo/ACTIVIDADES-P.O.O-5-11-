using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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

    class Vehiculo
    {
        private string marca;
        private int velocidadMaxima;

        public Vehiculo(string mar, int vel)
        {
            marca = mar;
            velocidadMaxima = vel;
        }

        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }

        public int VelocidadMaxima
        {
            set { velocidadMaxima = value; }
            get { return velocidadMaxima; }
        }
    }

    class Auto : Vehiculo
    {
        private int cantidadPuertas;

        public Auto(string mar, int vel, int puertas) : base(mar, vel)
        {
            cantidadPuertas = puertas;
        }

        public int CantidadPuertas
        {
            set { cantidadPuertas = value; }
            get { return cantidadPuertas; }
        }
    }

    class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string mar, int vel, int cc) : base(mar, vel)
        {
            cilindrada = cc;
        }

        public int Cilindrada
        {
            set { cilindrada = value; }
            get { return cilindrada; }
        }
    }

    class ControlVehiculos
    {
        private Auto miAuto;
        private Moto miMoto;

        public void IngresoDatos()
        {
            string linea;

            Console.Write("Ingrese marca del auto: ");
            string marcaAuto = Console.ReadLine();

            Console.Write("Ingrese velocidad máxima del auto: ");
            linea = Console.ReadLine();
            int velAuto = int.Parse(linea);
            Console.Write("Ingrese cantidad de puertas: ");
            linea = Console.ReadLine();
            int puertasAuto = int.Parse(linea);

            miAuto = new Auto(marcaAuto, velAuto, puertasAuto);

            // INGRESO DE LA MOTO
            Console.Write("\nIngrese marca de la moto: ");
            string marcaMoto = Console.ReadLine();
            Console.Write("Ingrese velocidad máxima de la moto: ");
            linea = Console.ReadLine();
            int velMoto = int.Parse(linea);
            Console.Write("Ingrese cilindrada: ");
            linea = Console.ReadLine();
            int ccMoto = int.Parse(linea);

            miMoto = new Moto(marcaMoto, velMoto, ccMoto);
        }

        public void MostrarReporte()
        {
            Console.WriteLine("Marca: " + miAuto.Marca);
            Console.WriteLine("Velocidad Máxima: " + miAuto.VelocidadMaxima + " km/h");
            Console.WriteLine("Cantidad de Puertas: " + miAuto.CantidadPuertas);
            Console.WriteLine("\n");
            Console.WriteLine("Marca: " + miMoto.Marca);
            Console.WriteLine("Velocidad Máxima: " + miMoto.VelocidadMaxima + " km/h");
            Console.WriteLine("Cilindrada: " + miMoto.Cilindrada + " cc");
        }

        static void Main(string[] args)
        {
            ControlVehiculos cv = new ControlVehiculos();
            cv.IngresoDatos();
            cv.MostrarReporte();

            Console.ReadKey();
        }
    }
}
