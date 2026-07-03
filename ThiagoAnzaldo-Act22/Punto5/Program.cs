using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    //Actividad 5: Gestión de Carreras Deportivas
    //Consigna:
    //Crear un sistema para gestionar carreras deportivas.Cada carrera tiene un código,
    //una hora de inicio y una hora de fin.Cada carrera puede registrar varios corredores.
    //Se pide:
    //1. Crear una clase Carrera con:
    //o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
    //definidos.
    //o Dos constructores (uno por defecto y otro con parámetros).
    //o Método para calcular la duración de la carrera usando TimeSpan.
    //2. Crear una clase Corredor con:
    //o Atributos: nombre, número de dorsal y tiempo total.
    //o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
    //horas y minutos).

    //3. Mostrar en consola(usando Console.SetCursorPosition()) :
    //o La carrera con mayor duración.
    //o El corredor más rápido.
    //4. Utilizar this en los constructores o métodos donde corresponda.
    
    class Corredor
    {
        private string nombre;
        private int numeroDorsal;
        private TimeSpan tiempoTotal;
        public Corredor(string nombre, int numeroDorsal)
        {
            this.nombre = nombre;
            this.numeroDorsal = numeroDorsal;
        }
        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = new TimeSpan(horas, minutos, 0);
        }
        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = TimeSpan.FromMinutes(minutos);
        }
    }
    class Carrera
    {
        private int codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<Corredor> corredores;

        public Carrera()
        {
            corredores = new List<Corredor>();
        }

        public Carrera(int codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.corredores = new List<Corredor>();
        }

        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;
        }

        static void Main(string[] args)
        {
            Carrera carrera1 = new Carrera(1, new DateTime(2026, 6, 1, 8, 0, 0), new DateTime(2026, 6, 1, 10, 0, 0));
            Carrera carrera2 = new Carrera(2, new DateTime(2026, 6, 1, 9, 30, 0), new DateTime(2026, 6, 1, 11, 30, 0));
            Carrera carrera3 = new Carrera(3, new DateTime(2026, 6, 1, 12, 0, 0), new DateTime(2026, 6, 1, 14, 30, 0));
            Carrera carrera4 = new Carrera(4, new DateTime(2026, 6, 1, 15, 0, 0), new DateTime(2026, 6, 1, 17, 30, 0));
            List<Carrera> carreras = new List<Carrera> { carrera1,carrera2,carrera3,carrera4};
            TimeSpan mayorDuracion = carreras[0].Duracion();
            int indiceMayorDuracion = 0;
            for (int i = 1; i < carreras.Count; i++)
            {
                if (carreras[i].Duracion() > mayorDuracion)
                {
                    mayorDuracion = carreras[i].Duracion();
                    indiceMayorDuracion = i;
                }
            }
            Console.SetCursorPosition(10,5);
            Console.WriteLine("La carrera con mayor duración es la de código: " + carreras[indiceMayorDuracion].codigo + " con una duración de: " + mayorDuracion);
            Console.ReadKey();  
        }
    }
}
