using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Actividad 3: Estadísticas de visitas a zonas arqueológicas
    //Problema:
    //Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    //arqueológicas durante 4 semanas.
    //Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
    //días.Luego:
    // Calcular el total de visitas por zona y almacenarlo en un vector.
    // Mostrar los datos en forma tabular.
    // Agregar estos resultados a una lista llamada zonasVisitadas que contenga
    //nombres de zonas y total de visitas.
    // Determinar cuál fue la zona más visitada.
    internal class InstitutoArqueologia
    {
        static void Main(string[] args)
        {
            int[,] visitas;
            int[] totalVisitas;

            List<(string zonas, int totalZonas)> zonasVisitas = new List<(string zonas, int totalZonas)>();

            visitas = new int[3, 4];
            totalVisitas = new int[3];
            int total = 0;
            int masVisitada = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("zona N°:" + i);
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("dia N°:" + j);
                    Console.WriteLine("ingrese el total de visitas");
                    visitas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("zonas:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
                total = 0;
                Console.Write("zona:" + (i + 1));
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("  " + visitas[i, j] + "  ");
                    total = total + visitas[i, j];
                }
                totalVisitas[i] = total;
                zonasVisitas.Add(("zona: "+ i + " ", total));
                Console.Write("total:" + totalVisitas[i]);
                Console.WriteLine("\n");
            }
            foreach (var m in zonasVisitas)
            {
                if (m.totalZonas > masVisitada)
                {
                    masVisitada = m.totalZonas;
                }
            }
            foreach (var m in zonasVisitas)
            {
                if (m.totalZonas == masVisitada)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("La zona mas visitada fue la " +m.zonas+ " con "+m.totalZonas);
                }
            }
            Console.ReadKey();
        }
    }
}
