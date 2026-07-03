using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Actividad 4: Gestión de vuelos
    //Problema:

    //Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada(DateTime).
    // Usar la palabra clave this en el constructor para diferenciar los parámetros de
    //los atributos.
    // Crear un método para calcular la duración del vuelo (TimeSpan).
    // Cargar un vector con 4 vuelos y mostrar:
    //1. El código y duración del vuelo más largo.
    //2. El código del vuelo que salga más temprano.
    internal class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan duracionVuelo()
        {
            TimeSpan duracion = horaLlegada - horaSalida;
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];

            vuelos[0] = new Vuelo("A123", new DateTime(2024, 6, 1, 8, 0, 0), new DateTime(2024, 6, 1, 10, 0, 0));
            vuelos[1] = new Vuelo("B456", new DateTime(2024, 6, 1, 9, 30, 0), new DateTime(2024, 6, 1, 11, 0, 0));
            vuelos[2] = new Vuelo("C789", new DateTime(2024, 6, 1, 12, 0, 0), new DateTime(2024, 6, 1, 14, 30, 0));
            vuelos[3] = new Vuelo("D012", new DateTime(2024, 6, 1, 15, 0, 0), new DateTime(2024, 6, 1, 17, 0, 0));
        
            TimeSpan mayorDuracion = vuelos[0].duracionVuelo();
            int d = 0;
            DateTime masTemprano= vuelos[0].horaSalida;
            int b= 0;
            for(int i = 0; i < 4; i++) 
            {
                if (vuelos[i].duracionVuelo() > mayorDuracion) 
                {
                    mayorDuracion = vuelos[i].duracionVuelo();
                    d = i;
                }
                if (vuelos[i].horaSalida < vuelos[b].horaSalida) 
                {
                    masTemprano = vuelos[i].horaSalida;
                    b = i;
                }
            }
            Console.WriteLine("el vuelo: "+vuelos[d].codigo+" es el de mayor duracion con: "+ mayorDuracion);
            Console.WriteLine("el vuelo: " + vuelos[b].codigo + " es el que sale mas temprano");

            Console.ReadKey();
        }
    }
}
