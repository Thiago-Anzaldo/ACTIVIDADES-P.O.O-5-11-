using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Actividad 1: Control de horarios en un gimnasio
    //Problema:
    //Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin(usar
    //DateTime).
    // Implementar un constructor que permita cargar los datos desde consola y otro
    //que cargue valores por defecto(sobrecarga de constructores).
    // Incluir un método para calcular la duración de la clase usando TimeSpan.
    // Crear un vector de 3 clases de gimnasio y mostrar:
    //1. La clase que tenga la mayor duración.
    //2. El nombre y el horario de inicio de la clase más temprana.
    internal class ClaseGimnasio    
    {
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin; 
        public ClaseGimnasio() 
        {
            string linea;

            Console.Write("ingresa el nombre de la clase: ");
            nombreClase = Console.ReadLine();

            Console.Write("ingresa el dia de la clase: ");
            linea= Console.ReadLine();
            int dia=int.Parse(linea);

            Console.Write("ingresa a que hora empieza la clase: ");
            linea = Console.ReadLine();
            int hora = int.Parse(linea);

            Console.Write("ingresa a que minuto inicia la clase: ");
            linea = Console.ReadLine();
            int minuto = int.Parse(linea);

            horaInicio = new DateTime(2026,7,dia,hora,minuto,00);

            Console.WriteLine(horaInicio);


            Console.Write("ingresa a que hora finaliza la clase: ");
            linea = Console.ReadLine();
            hora = int.Parse(linea);

            Console.Write("ingresa a que minuto finaliza la clase: ");
            linea = Console.ReadLine();
            minuto = int.Parse(linea);

            horaFin = new DateTime(2026, 7, dia, hora, minuto, 00);

            Console.WriteLine(horaFin);
        }

        public ClaseGimnasio(string nombreClase, int dia, int hora,int minuto, int horaF, int minutoF) 
        {
            this.nombreClase = nombreClase;


            horaInicio = new DateTime(2026, 7, dia, hora, minuto, 00);
            horaFin = new DateTime(2026, 7, dia, horaF, minutoF, 00);

            Console.WriteLine();
            Console.WriteLine(nombreClase);
            Console.WriteLine(horaInicio);
            Console.WriteLine(horaFin);
        }

        public TimeSpan duracion() 
        {
            return horaFin- horaInicio;
        }
        public DateTime horasInicio() 
        {
            return horaInicio;
        }

        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];

            clases[0] = new ClaseGimnasio("fuerza", 1, 2, 3, 4, 5);
            clases[1] = new ClaseGimnasio("resistencia", 8, 6, 4, 1, 5);
            clases[2] = new ClaseGimnasio("correr", 2, 3, 10, 2, 5);

            int mayorDuracion = 0;
            int masTemprana = 0;

            for (int i =0; i<3;i++)
            {
                if (clases[i].duracion() > clases[mayorDuracion].duracion()) 
                {
                    mayorDuracion = i;
                }
                if (clases[i].horasInicio() < clases[masTemprana].horasInicio()) 
                {
                    masTemprana = i;
                }
            }

            Console.WriteLine("La clase con mayor duracion es "+ clases[mayorDuracion].nombreClase+" con: " + clases[mayorDuracion].duracion());

            Console.WriteLine("la clase mas temprana es "+ clases[masTemprana].nombreClase);

            Console.ReadKey();
        }
    }
}
