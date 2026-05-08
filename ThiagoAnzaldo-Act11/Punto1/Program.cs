using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//  1. Se desea saber la temperatura media trimestral de cuatro paises.Para ello se tiene como
//  dato las temperaturas medias mensuales de dichos paises.
//  Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
//  mensuales.
//  Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
//  memoria.
//  a.Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
//  b.Imprimir los nombres de las paises y las temperaturas medias mensuales de las
//  mismas.
//  c.Calcular la temperatura media trimestral de cada país.
//  d.Imprimir los nombres de los paises y las temperaturas medias trimestrales.
//  e.Imprimir el nombre del país con la temperatura media trimestral mayor.
    internal class Temperatura
    {
        private string[] paises;
        private int[,] temperaturas;
        private double[] promedioTemperaturas;

        public void Carga() 
        {
            paises = new string[4];
            temperaturas = new int[4,3];
            string linea;

            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine("Escriba el nombre del pais del "+(i+1)+"°: ");
                paises[i]= Console.ReadLine();

                for(int j = 0; j < 3; j++) 
                {
                    Console.WriteLine("ingrese la "+(j+1)+"° temperatura: ");
                    linea = Console.ReadLine();
                    temperaturas[i,j]= int.Parse(linea);
                }
            }
            Console.WriteLine("\n");
        }

        public void MuestraPaisesConTemperaturas() 
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Las temperaturas de "+paises[i]+"son:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(temperaturas[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

        }

        public void PromedioTemperatura() 
        {
            promedioTemperaturas= new double[4];
            double sumaTotal = 0;

            for(int i = 0;i < 4; i++) 
            {
                for(int j = 0;j < 3; j++) 
                {
                    sumaTotal=sumaTotal+temperaturas[i,j];
                }
                promedioTemperaturas[i] = sumaTotal / 3;;
                sumaTotal = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Las temperaturas promedias de " + paises[i] + " son:");
                Console.Write(promedioTemperaturas[i] + " ");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        public void MayorPromedio()
        {
            string paisConMayorPromedio="";
            double mayorPromedioTemp = 0;

            for (int i = 0; i < 4; i++) 
            {
                if (promedioTemperaturas[i] > mayorPromedioTemp) 
                {
                    mayorPromedioTemp = promedioTemperaturas[i];
                    paisConMayorPromedio = paises[i];
                }
            }
            Console.WriteLine(paisConMayorPromedio+" tiene el mayor promedio de temperatura con: ");
            Console.WriteLine(mayorPromedioTemp);
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            Temperatura temp= new Temperatura();
            Console.ReadKey();
            temp.Carga();
            temp.MuestraPaisesConTemperaturas();
            temp.PromedioTemperatura();
            temp.MayorPromedio();
        }
    }
}