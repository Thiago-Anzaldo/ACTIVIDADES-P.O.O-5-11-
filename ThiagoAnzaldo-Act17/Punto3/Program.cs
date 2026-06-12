using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    //3. Fábrica de Computadoras(Herencia y Constructores con base)
    //Crear una clase base llamada Computadora que contenga los atributos Marca y
    //MemoriaRAM(en GB). Definir un constructor que reciba estos dos obligatoriamente.
    //Luego, definir dos clases derivadas de la clase base:
    // Notebook: que añade el atributo propio TamanoPantalla(en pulgadas).
    // Escritorio: que añade el atributo propio PotenciaFuente(en Watts).
    //Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
    //tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
    //clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
    //de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
    class Computadora
    {
        private string Marca;
        private int MemoriaRam;

        public Computadora()
        {
            string linea;
            Console.Write("Escriba la marca: ");
            Marca = Console.ReadLine();

            Console.Write("De cuanto es la Memoria RAM: ");
            linea = Console.ReadLine();
            MemoriaRam = int.Parse(linea);
        }

        public string ObtenerMarca
        {
            get
            {
                return Marca;
            }
        }

        public int ObtenerMemoriaRAM
        {
            get
            {
                return MemoriaRam;
            }
        }
    }

    class Escritorio : Computadora
    {
        private int PotencioWatts;

        public Escritorio() 
        {
            string linea;
            Console.Write("Ingrese el tamaño de la notebook: ");
            linea = Console.ReadLine();
            PotencioWatts = int.Parse(linea);
            Console.WriteLine("\n");
        }
        public void muestraEsc()
        {
            Console.WriteLine("Marca: " + ObtenerMarca);
            Console.WriteLine("Memoria RAM " + ObtenerMemoriaRAM);
            Console.WriteLine("Potencia en watts: " + PotencioWatts);
        }
    }

    class Notebook : Computadora
    {
        private float TamañoPantalla;

        public Notebook()
        {
            string linea;
            Console.Write("Ingrese el tamaño de la notebook: ");
            linea = Console.ReadLine();
            TamañoPantalla = float.Parse(linea);
            Console.WriteLine("\n");
        }
        public void muestraNB()
        {
            Console.WriteLine("Marca NB: " + ObtenerMarca);
            Console.WriteLine("Memoria RAM " + ObtenerMemoriaRAM);
            Console.WriteLine("Tamaño de pantalla en pulgadas: "+TamañoPantalla);
        }

        static void Main(string[] args)
        {
            Notebook nb = new Notebook();
            Escritorio esc=new Escritorio();
            esc.muestraEsc();
            nb.muestraNB();

            Console.ReadKey();  
        }
    }
}