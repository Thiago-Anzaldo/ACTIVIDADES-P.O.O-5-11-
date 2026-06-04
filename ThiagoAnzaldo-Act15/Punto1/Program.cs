using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto1
{
//    1. Monitoreo Clínico de Pacientes
//En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
//cardíaco de los pacientes.
//● Plantear una clase llamada Paciente que tenga como atributos privados:
//1. Nombre(de tipo string).
//2. Una matriz llamada ritmoCardiaco de tamaño 3x4(representando los
//registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
//clave de cada día: mañana, mediodía, tarde y noche).
//3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
//teclado de las 12 lecturas cardíacas.

//● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
//objetos de la clase Paciente.Su constructor debe inicializar el vector y solicitar la
//carga de los 3 pacientes.Implementar los siguientes métodos dentro de
//SalaMonitoreo:
//1. Un método que imprima la grilla de lecturas cardíacas completa de cada
//paciente organizada por día y momento.
//2. Un método que calcule e imprima el promedio de pulsaciones de cada
//paciente a lo largo de todo su monitoreo.
//3. Un método que verifique si algún paciente registró un evento de taquicardia
//severa (cualquier lectura individual que sea estrictamente mayor a 120
//pulsaciones), mostrando por consola su nombre y la lectura detectada.
    class Paciente 
    {
        private string nombre;
        private int[,] ritmoCardiaco;

        public Paciente()
        {
            string linea;
            ritmoCardiaco = new int[3, 4];

            Console.Write("ingrese el nombre del paciente: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Ingrese el ritmo cardiaco del dia " + (i + 1) + ": ");
                for (int j = 0; j < 4; j++) 
                {
                    Console.Write("Ingrese el ritmo cardiaco (Mañana, mediodia, tarde y noche): ");
                    linea = Console.ReadLine();
                    ritmoCardiaco[i, j] = int.Parse(linea); 
                }
            }
        }

        public string nombrePaciente() 
        {
            return nombre;
        }

        public int ritmoCardiacoPaciente(int dia, int horario)
        {
            return ritmoCardiaco[dia, horario];
        }
    }

    class SalaDeMonitoreo
    {
        private Paciente[] pacientes;


        public SalaDeMonitoreo() 
        {
            pacientes = new Paciente[3];
            for (int i = 0; i < 3; i++)
            {
                pacientes[i] = new Paciente();
            }
        }

        public void mostrarGrilla() 
        {
            for (int d=0; d<3; d++) {

                Console.WriteLine("paciente: " + pacientes[d].nombrePaciente());
                Console.WriteLine("ritmo cardiaco(mañana, mediodia, tarde y noche): "); 

                for (int i = 0; i < 3; i++) 
                {
                    Console.WriteLine("dia: " + (i + 1));
                    for (int j = 0; j < 4; j++) 
                    {
                        Console.WriteLine(pacientes[d].ritmoCardiacoPaciente(i, j));
                    }
                }
            }
            Console.WriteLine("\n");
        }

        public void promedioRitmoCardiaco() 
        {
            for (int d=0; d<3; d++) {

                double sumaRitmoCardiaco = 0;

                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 4; j++)
                    {
                        sumaRitmoCardiaco += pacientes[d].ritmoCardiacoPaciente(i, j);
                    }
                }
                    sumaRitmoCardiaco= sumaRitmoCardiaco/ 12;
                    Console.WriteLine("El promedio del ritmo cardiaco del paciente " + pacientes[d].nombrePaciente() + " es: " + sumaRitmoCardiaco );

                    sumaRitmoCardiaco = 0;
                
            }
            Console.WriteLine("\n");
        }

        public void verificacionCardiaca() 
        {
            for (int d = 0; d < 3; d++) 
            {
                for (int i = 0; i < 3; i++) 
                {
                    for(int j = 0;j < 4; j++) 
                    {
                        if (pacientes[d].ritmoCardiacoPaciente(i, j) > 120) 
                        {
                            Console.WriteLine("el paciente " + pacientes[d].nombrePaciente() + " tiene un ritmo cardiaco alto con: " + pacientes[d].ritmoCardiacoPaciente(i, j));
                        }
                    }
                }
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            SalaDeMonitoreo sala = new SalaDeMonitoreo();
            sala.mostrarGrilla();
            sala.promedioRitmoCardiaco();
            sala.verificacionCardiaca();
        }
    }
}
