using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto4
{
//    4. Línea de Ensamblaje Robótico
//En una planta de fabricación automatizada, cada robot industrial realiza tareas de
//ensamblaje complejas divididas en operaciones secundarias de duración variable.
//● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
//1. ModeloRobot.
//2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
//fila representa una de las 4 fases principales del proceso (Estructura,
//Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
//completar las distintas subtareas de esa fase(por ejemplo, en la fase de
//Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
//1).
//3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
//cada una de las 4 fases de fabricación cuántas sub - tareas requirió realizar

//(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
//una de ellas.

//● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
//RobotEnsamblador.Implementar en PlantaIndustrial:
//1. Un constructor que cargue la información de los 3 robots instalados en la
//planta.
//2. Un método que muestre un reporte detallado con los tiempos de operación
//de cada robot fase por fase.
//3. Un método que calcule el promedio general de tiempo por tarea de cada
//robot y declare al &quot; Robot más Eficiente & quot; (aquel que registre el promedio de
//tiempo por operación más bajo de la planta).

    class RobotEnsamblador 
    {
        private int[] tareas;
        private string[] fases;
        private string ModeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            tareas = new int[4];
            fases = new string[4];
            fases[0] = "Estructura";
            fases[1] = "Cableado";
            fases[2] = "Pintura";
            fases[3] = "Testeo";
            tiemposOperacion = new float[4][];
            string linea;

            Console.Write("Ingrese el modelo del robot: ");
            ModeloRobot = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresar cuantas tareas se realizaron en " + fases[i] + ": ");
                linea = Console.ReadLine();
                tiemposOperacion[i] = new float[int.Parse(linea)];
            }

            for (int i = 0; i < tiemposOperacion.Length; i++)
            {
                for (int j = 0; j < tiemposOperacion[i].Length; j++)
                {
                    Console.Write("Cuanto se tardo en las tareas de " + fases[i] + " tarea " + (j + 1) + ": ");
                    linea = Console.ReadLine();
                    tiemposOperacion[i][j] = float.Parse(linea);
                }
            }

            for (int i = 0; i < tiemposOperacion.Length; i++)
            {
                tareas[i] = tiemposOperacion[i].Length;
            }
        }
        public int tareasCantidad(int tarea)
        {
            return tareas[tarea];
        }
        public string fasesRobot(int fasesTareas) 
        {
            return fases[fasesTareas];
        }

        public string nombreRobot() 
        {
            return ModeloRobot;
        }

        public float tiemposRobot(int tareas, int tiempoTardado) 
        {
            return tiemposOperacion[tareas][tiempoTardado];
        }
    }
    class PlantaIndustrial
    {
        private RobotEnsamblador[] planta;
        public PlantaIndustrial() 
        {
            planta = new RobotEnsamblador[3];
            for (int i = 0; i < 3; i++)
            {
                planta[i] = new RobotEnsamblador();
            }
        }

        public void muestraGeneral() 
        {
            for (int i = 0;i < 3; i++) 
            {
                Console.WriteLine((i+1)+"° ROBOT:");
                Console.WriteLine(planta[i].nombreRobot());

                for(int d=0; d < 4; d++) 
                {
                    Console.WriteLine("-"+planta[i].fasesRobot(d));
                    for(int p = 0; p < planta[i].tareasCantidad(d); p++) 
                    {
                        Console.WriteLine((p+1)+"° Sub-tarea, tiempo tardado: "+planta[i].tiemposRobot(d,p)+" seg");
                        
                    }
                }
                Console.WriteLine("\n");
            }
        }

        public void robotEficiente()
        {
            float[] promediosFinal;
            promediosFinal = new float[3];
            int cantTareas=0;
            float promedio=0;
            for (int i = 0; i < 3; i++)
            {
                for (int d = 0; d < 4; d++)
                {
                    cantTareas = cantTareas + planta[i].tareasCantidad(d);
                    for (int p = 0; p < planta[i].tareasCantidad(d); p++)
                    {
                        promedio = promedio + planta[i].tiemposRobot(d,p);
                    }
                }
                promedio = promedio / cantTareas;

                promediosFinal[i] = promedio;
                cantTareas = 0;
                promedio = 0;
            }
            string robotMasEficiente = planta[0].nombreRobot();
            float robotEficiente=promediosFinal[0];
            for(int i = 0; i < 3; i++) 
            {
                if (promediosFinal[i]<robotEficiente) 
                {
                    robotEficiente = promediosFinal[i];
                    robotMasEficiente=planta[i].nombreRobot();
                }
            }

            Console.WriteLine("El robot mas eficiente es: "+robotMasEficiente);
            Console.WriteLine("Con: "+robotEficiente+" seg");
        }
        static void Main(string[] args)
        {
            PlantaIndustrial pi = new PlantaIndustrial();
            pi.muestraGeneral();
            pi.robotEficiente();
            Console.ReadKey();
        }
    }
}
