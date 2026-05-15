using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
//    1. Sistema de Logística: Envíos por Sucursal
//      Una empresa de correo tiene 3 sucursales principales.Cada sucursal procesa una
//      cantidad diferente de paquetes por día dependiendo de su demanda.
//          ● Definir un vector de tipo string para los nombres de las 3 sucursales.
//          ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
//          represente el peso (en kg) de cada paquete enviado.
//          ● Métodos:
//              1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
//              paquetes se enviaron hoy para definir el tamaño de su fila.
//              2. Cargar el peso de cada paquete.
//              3. Imprimir el peso de todos los paquetes organizados por sucursal.
//              4. Calcular e informar el peso total despachado por cada sucursal.
//              5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
//              pertenece.
    internal class SistemaDeLogistica
    {
        private int[] totalPeso;
        private int[][] enviosSucursales;
        private string[] nombreSucursales;

        public void CargaNombresYPaquetesEnviados() 
        {
            enviosSucursales = new int[3][];
            nombreSucursales = new string[3];
            string linea;
            int cantidadEnvios = 0;

            for (int i = 0; i < nombreSucursales.Length; i++) 
            {
                Console.Write("Nombre de la "+(i+1)+"° sucursal: ");
                nombreSucursales[i]=Console.ReadLine();

                Console.Write("Cuantos paquetes enviaron: ");
                linea = Console.ReadLine();
                cantidadEnvios = int.Parse(linea);

                enviosSucursales[i] = new int[cantidadEnvios];
            }
        }

        public void CargaDePesos() 
        {
            string linea;
            for (int i = 0; i < nombreSucursales.Length; i++) 
            {
                Console.WriteLine("pesos de los paquetes del la sucursal " + nombreSucursales[i]);
                for(int j = 0; j < enviosSucursales[i].Length; j++) 
                {
                    Console.Write("Peso del " + (j + 1) + "° paquete:   ");
                    linea=Console.ReadLine();
                    enviosSucursales[i][j] = int.Parse(linea);
                }
            }
            Console.WriteLine("\n");
        }
        public void MuestraDeEnvios() 
        {
            for (int i = 0; i < nombreSucursales.Length; i++)
            {
                Console.WriteLine("sucursal: " + nombreSucursales[i] + " paquetes: ");
                for (int j = 0; j < enviosSucursales[i].Length; j++)
                {
                    Console.Write("paquete N°"+(j+1)+": "+enviosSucursales[i][j]);
                    Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
        }
        public void TotalDelPesoDeLosPaquetes() 
        {
            totalPeso = new int[3];
            int sumaTotal = 0;
            for (int i = 0; i < nombreSucursales.Length; i++) 
            {
                for(int j = 0; j < enviosSucursales[i].Length; j++) 
                {
                    sumaTotal = sumaTotal + enviosSucursales[i][j];
                }
                totalPeso[i] = sumaTotal;
                sumaTotal = 0;
            }
            for(int i = 0;i < totalPeso.Length; i++) {
                Console.WriteLine("nombre de la sucursal: " + nombreSucursales[i]);
                Console.WriteLine("peso total: "+totalPeso[i]+"kg");
            }
            Console.WriteLine("\n");
        }

        public void CargaMasPesada() 
        {
            string sucursalPaqueteMasPesado = "";
            int numeroPaquete = 0;
            int paqueteMasPesado = 0;
            for (int i = 0; i < nombreSucursales.Length; i++)
            {
                for (int j = 0; j < enviosSucursales[i].Length; j++) 
                {
                    if (enviosSucursales[i][j] > paqueteMasPesado) 
                    {
                        sucursalPaqueteMasPesado = nombreSucursales[i];
                        paqueteMasPesado=enviosSucursales[i][j];
                        numeroPaquete = j+1;
                    }
                }            
            }
            Console.WriteLine("ENVIO MAS PESADO!!");
            Console.WriteLine("nombre de la sucursal: "+sucursalPaqueteMasPesado);
            Console.WriteLine("peso del paquete: "+paqueteMasPesado+"kg");
            Console.WriteLine("numero de paquete: N°"+numeroPaquete);
        }
        static void Main(string[] args)
        {
            SistemaDeLogistica sdl=new SistemaDeLogistica();
            sdl.CargaNombresYPaquetesEnviados();
            sdl.CargaDePesos();
            sdl.MuestraDeEnvios();
            sdl.TotalDelPesoDeLosPaquetes();
            sdl.CargaMasPesada();
            Console.ReadKey();
        }
    }
}
