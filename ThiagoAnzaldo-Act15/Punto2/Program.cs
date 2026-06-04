using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
//    2. Logística de Puerto Espacial
//Una estación de acoplamiento registra el peso de los contenedores transportados en las
//bodegas de carga de las naves espaciales que llegan al puerto.
//● Crear la clase NaveEspacial que contenga únicamente el atributo privado
//NombreNave y su constructor para cargarlo.
//● Crear la clase colaboradora PuertoControl que contenga:
//○ Un vector de 3 objetos de la clase NaveEspacial.
//○ Una matriz irregular de tipo double llamado pesoContenedores, donde
//cada fila representa a una nave, el tamaño de la fila es la cantidad de
//bodegas que posee esa nave, y los valores almacenados son los pesos (en
//toneladas) de los contenedores que transporta cada bodega.

//En PuertoControl, definir los siguientes métodos:

//1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
//cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
//irregular) y cargue el peso del contenedor asignado a cada bodega.
//2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
//espacial.
//3. Un método que identifique e informe qué nave transporta el contenedor individual
//más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
//irregular).
//4. Un método que indique el nombre de la nave que transporta menor peso acumulado
//total(la suma de todos sus contenedores).
    class NaveEspacial
    {
        private string NombreNave;

        public NaveEspacial()
        {
            Console.Write("Ingrese el nombre de la nave espacial: ");
            NombreNave = Console.ReadLine();
        }

        public string nombreDeNave()
        {
            return NombreNave;
        }
    }
    class PuertoControl
    {
        private NaveEspacial[] naves;
        private double[][] pesoContenedores;

        public PuertoControl()
        {
            naves = new NaveEspacial[3];
            pesoContenedores = new double[3][];
            string linea;

            for (int i = 0; i < 3; i++)
            {
                naves[i] = new NaveEspacial();

                Console.Write("ingrese la cantidad de bodegas activas: ");
                linea = Console.ReadLine();
                pesoContenedores[i] = new double[int.Parse(linea)];
                Console.WriteLine("\n");
            }

            for (int i = 0; i < pesoContenedores.Length; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.Write("ingrese el peso en toneladas de la nave " + naves[i].nombreDeNave() + " bodega " + (j + 1) + ": ");
                    linea = Console.ReadLine();
                    pesoContenedores[i][j] = double.Parse(linea);
                }
            }
        }

        public void muestraGeneral()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine((i + 1) + "° nave:");
                Console.WriteLine(naves[i].nombreDeNave());

                for (int p = 0; p < pesoContenedores[i].Length; p++)
                {
                    Console.WriteLine((p + 1) + "° bodega, peso de contenedor: " + pesoContenedores[i][p] + " toneladas");
                }
                Console.WriteLine("\n");
            }
        }

        public void ContenedorMasPesado()
        {
            double maxPeso = pesoContenedores[0][0];
            string naveMaxPeso = naves[0].nombreDeNave();

            for (int i = 0; i < pesoContenedores.Length; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    if (pesoContenedores[i][j] > maxPeso)
                    {
                        maxPeso = pesoContenedores[i][j];
                        naveMaxPeso = naves[i].nombreDeNave();
                    }
                }
            }

            Console.WriteLine("la nave con el contenedor mas pesado es: " + naveMaxPeso);
            Console.WriteLine("con un peso de: " + maxPeso + " toneladas");
            Console.WriteLine("\n");
        }
        public void NaveMenorPesoAcumulado()
        {
            double[] pesosTotalesPorNave;
            pesosTotalesPorNave = new double[3];
            double sumaFila = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    sumaFila = sumaFila + pesoContenedores[i][j];
                }
                pesosTotalesPorNave[i] = sumaFila;
                sumaFila = 0;
            }

            string naveMenorPeso = naves[0].nombreDeNave();
            double menorPesoAcumulado = pesosTotalesPorNave[0];

            for (int i = 0; i < 3; i++)
            {
                if (pesosTotalesPorNave[i] < menorPesoAcumulado)
                {
                    menorPesoAcumulado = pesosTotalesPorNave[i];
                    naveMenorPeso = naves[i].nombreDeNave();
                }
            }

            Console.WriteLine("la nave que transporta menor peso acumulado total es: " + naveMenorPeso);
            Console.WriteLine("con un total de: " + menorPesoAcumulado + " toneladas");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            PuertoControl puerto = new PuertoControl();
            puerto.muestraGeneral();
            puerto.ContenedorMasPesado();
            puerto.NaveMenorPesoAcumulado();
            Console.ReadKey();
        }
    }
}