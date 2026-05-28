using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//    1. El Sistema de Peaje.
//Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
//La clase Vehiculo debe tener los siguientes atributos privados:
//  -Patente (de tipo string).
//  -Tipo(puede ser "Auto", "Camion" o "Moto").
//  -Tarifa(un valor decimal que representa el costo de su pase).
//El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
//La clase CabinaPeaje debe tener como atributos privados:
//  -El número o identificador de la cabina.
//  -Tres objetos de la clase Vehiculo(que representan los últimos 3 vehículos que pagaron en esa cabina).
//Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos.
//Además, implementar los siguientes métodos dentro de CabinaPeaje:
//  1-Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
//  2-Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
//  3-Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    class Vehiculo 
    {
        private string patente;
        private string tipo;
        private double tarifa;

        public Vehiculo()
        {
            string linea = "";

            Console.Write("Escriba la patente del auto: ");
            patente=Console.ReadLine();

            Console.Write("Escriba su tipo de auto: ");
            tipo = Console.ReadLine();

            Console.Write("Escriba su tarifa: ");
            linea = Console.ReadLine();
            tarifa=int.Parse(linea);
        }

        public string PatenteAuto() 
        {
            return patente;
        }
        public string TipoAuto() 
        {
            return tipo;
        }
        public double TarifaAuto() 
        {
            return tarifa;
        }
    }
    class CabinaPeaje
    {
        private Vehiculo auto1, auto2, auto3;

        public CabinaPeaje() 
        {
            auto1 = new Vehiculo();
            auto2 = new Vehiculo();
            auto3 = new Vehiculo();
        }

        public void PatenteYTipoAuto() 
        {
            Console.WriteLine("\n");
            Console.WriteLine("Patente del auto "+ auto1.PatenteAuto());
            Console.WriteLine("Tipo de auto: "+ auto1.TipoAuto());
            Console.WriteLine("Patente del auto "+ auto2.PatenteAuto());
            Console.WriteLine("Tipo de auto: " + auto2.TipoAuto());
            Console.WriteLine("Patente del auto " + auto3.PatenteAuto());
            Console.WriteLine("Tipo de auto: " + auto3.TipoAuto());
            Console.WriteLine("\n");
        }

        public void RecaudacionTotal() 
        {
            double taritaTotal;

            taritaTotal = auto1.TarifaAuto() + auto2.TarifaAuto() + auto3.TarifaAuto();

            Console.WriteLine("La tarifa total es: "+ taritaTotal);
            Console.WriteLine("\n");
        }
        public void TarifaCara() 
        {
            double TarifaMasCara=auto1.TarifaAuto() ;
            string patenteTarifaMasCara =auto1.PatenteAuto();

            if (auto2.TarifaAuto() > TarifaMasCara)
            {
                TarifaMasCara = auto2.TarifaAuto();
                patenteTarifaMasCara = auto2.PatenteAuto();
            }
            if (auto3.TarifaAuto() > TarifaMasCara)
            {
                TarifaMasCara = auto3.TarifaAuto();
                patenteTarifaMasCara = auto3.PatenteAuto();
            }

            Console.WriteLine("Patente del auto con la tarifa mas alta: " + patenteTarifaMasCara);
            Console.WriteLine("Tarifa: " + TarifaMasCara);
        }

        static void Main(string[] args)
        {
            CabinaPeaje cabina = new CabinaPeaje();
            cabina.PatenteYTipoAuto();
            cabina.RecaudacionTotal();
            cabina.TarifaCara();
            Console.ReadKey();
        }
    }
}
