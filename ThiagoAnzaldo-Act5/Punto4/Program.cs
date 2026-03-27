using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor.*/

            float edad, sumaTurnoMñ, sumaTurnoTar, sumaTurnoNo,promedioTarde,promedioMañana,promedioNoche;
            string linea;

            sumaTurnoMñ = 0;
            sumaTurnoNo = 0;
            sumaTurnoTar = 0;

            for(int m = 0; m < 10; m++)
            {
                Console.Write("Ingrese la edad de un alumno de la mañana: ");
                linea = Console.ReadLine();
                edad = float.Parse(linea);
                Console.WriteLine("");

                sumaTurnoMñ = edad + sumaTurnoMñ;
            }
            for (int m = 0; m < 15; m++)
            {
                Console.Write("Ingrese la edad de un alumno de la tarde: ");
                linea = Console.ReadLine();
                edad = float.Parse(linea);
                Console.WriteLine("");

                sumaTurnoTar = edad + sumaTurnoTar;
            }
            for (int m = 0; m < 7; m++)
            {
                Console.Write("Ingrese la edad de un alumno de la noche: ");
                linea = Console.ReadLine();
                edad = float.Parse(linea);
                Console.WriteLine("");

                sumaTurnoNo = edad + sumaTurnoNo;
            }

            promedioMañana = sumaTurnoMñ / 20;
            promedioNoche = sumaTurnoNo / 15;
            promedioTarde = sumaTurnoTar / 30;
            Console.WriteLine("promedio de turno mañana: :"+promedioMañana);
            Console.WriteLine("promedio de turno tarde: "+promedioTarde);
            Console.WriteLine("promedio de turno noche: "+promedioNoche);

            if (promedioMañana<promedioNoche && promedioMañana<promedioTarde)
            {
                Console.WriteLine("el promedio menor de edad es el turno mañana");
            }
            else if(promedioTarde<promedioMañana && promedioTarde < promedioNoche)
            {
                Console.WriteLine("el promedio menor de edad es el turno tarde");
            }
            else
            {
                Console.WriteLine("el promedio menor de edad es el turno noche");
            }
            Console.ReadKey();
        }
    }
}
