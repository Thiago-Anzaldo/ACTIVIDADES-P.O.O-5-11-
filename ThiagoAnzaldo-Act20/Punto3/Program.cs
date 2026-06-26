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
        private int[,] visitas;

        public InstitutoArqueologia()
        {
            string linea;
            visitas = new int[3,4];

            for(int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 4; j++) 
                {
                                                                    
                }
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
