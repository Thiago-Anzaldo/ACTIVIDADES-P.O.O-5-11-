using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Actividad 3: Registro de entrenamientos
    //Problema:
    //Plantear una clase Entrenamiento con atributos: deportista y duración(en minutos).
    // Incluir dos métodos RegistrarDuracion(sobrecarga de métodos):
    //1. Uno que reciba horas y minutos y los convierta a minutos.
    //2. Otro que reciba directamente los minutos.
    // Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
    //más corto.
    internal class Entrenamiento
    {
        private int duracion;
        private string deportista;

        public Entrenamiento(string deportista)
        {
            this.deportista = deportista;
        }

        public void ObtenerDuracion(int horas, int minutos)
        {
            duracion = (horas * 60) + minutos;
        }

        public void ObtenerDuracion(int minutos)
        {
            duracion = minutos;
        }
        static void Main(string[] args)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            Entrenamiento e1 = new Entrenamiento("juan");
            e1.ObtenerDuracion(1, 30);

            Entrenamiento e2 = new Entrenamiento("marcos");
            e2.ObtenerDuracion(180);

            Entrenamiento e3 = new Entrenamiento("jorge");
            e3.ObtenerDuracion(2, 15);

            Entrenamiento e4 = new Entrenamiento("alex");
            e4.ObtenerDuracion(90);

            Entrenamiento e5 = new Entrenamiento("dylan");
            e5.ObtenerDuracion(1, 45);

            entrenamientos.Add(e1);
            entrenamientos.Add(e2);
            entrenamientos.Add(e3);
            entrenamientos.Add(e4);
            entrenamientos.Add(e5);

            Entrenamiento masLargo = entrenamientos[0];
            Entrenamiento masCorto = entrenamientos[0];

            foreach (Entrenamiento e in entrenamientos)
            {
                if (e.duracion > masLargo.duracion)
                {
                    masLargo = e;
                }
                if (e.duracion < masCorto.duracion)
                {
                    masCorto = e;
                }
            }

            Console.WriteLine("entrenamiento mas largo: " + masLargo.duracion + " hecho por: " + masLargo.deportista);
            Console.WriteLine("entrenamiento mas corto: " + masCorto.duracion + " hecho por: " + masCorto.deportista);

            Console.ReadKey();
        }
    }
}