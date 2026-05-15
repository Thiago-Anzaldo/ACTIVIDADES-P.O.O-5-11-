using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Punto2
{
//        Un cine tiene 4 salas con diferentes capacidades de espectadores(la Sala 1 tiene 10
//        asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
//          ● Definir una matriz irregular de 4 filas para representar los asientos.
//          ● Métodos:
//              1. Inicializar la matriz con los tamaños de las salas mencionadas(sin
//              intervención del operador).
//              2. Crear un método de &quot; Venta de Entradas & quot; que permita cargar la edad del
//              espectador en un asiento específico(fila y columna).
//              3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
//              en cada asiento.
//              4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
//              5. Informar cuál es el promedio de edad de los espectadores de todo el
//              complejo.
    internal class SalasDeCine
    {
        private int[][] salasCine;
        private int[] menoresDeEdad;

        public void Carga()
        {
            salasCine = new int[4][];
            salasCine[0] = new int[10];
            salasCine[1] = new int[15];
            salasCine[2] = new int[8];
            salasCine[3] = new int[12];
        }
        public void VentaDeEntradas() 
        {
            string linea;
            for (int i = 0; i < 4; i++) 
            {
                for(int j = 0; j < salasCine[i].Length; j++) 
                {
                    Console.Write("Ingrese la edad del asiento fila: "+(i+1)+" y columna "+(j+1)+": ");
                    linea=Console.ReadLine();
                    salasCine[i][j]=int.Parse(linea);
                }
            }
            Console.WriteLine();
        }
        public void MapaDeOcupacion() 
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sala "+(i+1));
                for (int j = 0; j < salasCine[i].Length; j++)
                {
                    Console.WriteLine("asiento " +(j+1)+" edad: "+salasCine[i][j]);
                }
            }
        }
        public void CalculoDeMenoresDeEdad() 
        {
            menoresDeEdad = new int[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < salasCine[i].Length; j++)
                {
                    if (salasCine[i][j] != 0) 
                    { 
                        if (salasCine[i][j] < 18) 
                        {
                        menoresDeEdad[i]++;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++) 
            {
                if (menoresDeEdad[i] == 0) 
                {
                    Console.WriteLine("En la sala " + (i + 1) + " no hay ningun menor de edad");
                }
                else if (menoresDeEdad[i] == 1) { 
                Console.WriteLine("En la sala "+(i+1)+" hay: " + menoresDeEdad[i]+" menor de edad");
                }
                else if (menoresDeEdad[i] > 1) 
                {
                    Console.WriteLine("En la sala " + (i + 1) + " hay: " + menoresDeEdad[i] + " menores de edad");
                }
            }
        }
        public void PromedioEdad() 
        {
            double promedioEdad = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < salasCine[i].Length; j++)
                {
                    if (salasCine[i][j] >0) 
                    { 
                    promedioEdad += salasCine[i][j];
                    }
                }
            }
            Console.WriteLine(promedioEdad);
            Console.WriteLine(a);
            Console.WriteLine("\n");
            promedioEdad = promedioEdad / 45;

            Console.WriteLine("el promedio de edad es: "+promedioEdad);
        }
        static void Main(string[] args)
        {
            SalasDeCine sdc=new SalasDeCine();
            sdc.Carga();
            sdc.VentaDeEntradas();
            sdc.MapaDeOcupacion();
            sdc.CalculoDeMenoresDeEdad();
            sdc.PromedioEdad();
            Console.ReadKey();
        }
    }
}