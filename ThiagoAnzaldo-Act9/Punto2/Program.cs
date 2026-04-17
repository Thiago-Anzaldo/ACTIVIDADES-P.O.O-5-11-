using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Empresa
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.*/
        private int[] ventas;
        private string[] vendedores;

        public void Carga() 
        {
            ventas = new int[5];
            vendedores = new string[5];
            string linea;

            for (int i = 0; i < 5; i++) 
            {
                Console.Write("Nombre del vendedor: ");
                vendedores[i] = Console.ReadLine();

                Console.Write("Ingrese el total de ventas: ");
                linea = Console.ReadLine();
                ventas[i]= int.Parse(linea);
            }
            Console.WriteLine("\n");
        }

        public void MayorAMenor()
        {
            int auxVen = 0;
            string auxVend = "";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (ventas[j] < ventas[j + 1])
                    {
                        auxVen = ventas[j];
                        ventas[j] = ventas[j + 1];
                        ventas[j + 1] = auxVen;

                        auxVend = vendedores[j];
                        vendedores[j] = vendedores[j + 1];
                        vendedores[j + 1] = auxVend;
                    }
                }
            }
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("El vendedor " +vendedores[i]);
                Console.WriteLine("Hizo un total de "+ventas[i]+" ventas");
                Console.WriteLine("\n");
            }
        }
        public void MenosVentas() 
        {
            int ventasBajas = ventas[0];
            string vendedorFracasado="";

            for(int i = 1;i < 5; i++) 
            {
                if (ventas[i] < ventasBajas)
                {
                    ventasBajas = ventas[i];
                    vendedorFracasado = vendedores[i];
                }
            }
            Console.WriteLine("El vendedor que menos vendio fue: "+vendedorFracasado);
            Console.WriteLine("con un total de "+ventasBajas+" ventas");
        }
        static void Main(string[] args)
        {
            Empresa e = new Empresa();
            e.Carga();
            e.MayorAMenor();
            e.MenosVentas();
            Console.ReadKey();
        }
    }
}
