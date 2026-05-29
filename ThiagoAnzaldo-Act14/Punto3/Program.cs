using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
//    3. Competencia de Atletismo
//Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos(tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
//Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
//Definir los siguientes métodos en la clase Carrera:
//Un constructor que cargue los datos de los 3 atletas de la carrera.
//Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
//Un método que calcule e imprima el tiempo promedio de la carrera.
//Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
//Un método que muestre a los atletas que superaron el promedio.

    class Atleta 
    {
        private int tiempo;
        private string nombre;

        public Atleta() 
        {
            string linea;

            Console.Write("Ingrese el nombre del atleta: ");
            nombre=Console.ReadLine();

            Console.Write("Ingrese su tiempo: ");
            linea=Console.ReadLine();
            tiempo=int.Parse(linea);
        }
    
        public int tiempoAtleta() 
        {
            return tiempo;
        }
        public string nombreAtleta()
        {
            return nombre;
        }
    }

    class Carrera
    {
        private Atleta atleta1, atleta2, atleta3;
        private double promedio;

        public Carrera() 
        {
            atleta1 = new Atleta();
            atleta2 = new Atleta();
            atleta3 = new Atleta();
        }

        public void MuestraDatos() 
        {
            Console.WriteLine("Nombre: " + atleta1.nombreAtleta());
            Console.WriteLine("Tiempo: " + atleta1.tiempoAtleta());
            Console.WriteLine("\n");

            Console.WriteLine("Nombre: " + atleta2.nombreAtleta());
            Console.WriteLine("Tiempo: " + atleta2.tiempoAtleta());
            Console.WriteLine("\n");

            Console.WriteLine("Nombre: " + atleta3.nombreAtleta());
            Console.WriteLine("Tiempo: " + atleta3.tiempoAtleta());
            Console.WriteLine("\n");

        }

        public void PromedioTiempo()
        {
            promedio = 0;

            promedio= atleta1.tiempoAtleta()+ atleta2.tiempoAtleta()+ atleta3.tiempoAtleta();

            promedio = promedio / 3;
            
            Console.WriteLine("promedio de tiempo: "+ promedio);
        }
        
        public void MenorTiempo() 
        {
            string atletaMenorTiempo = "";
            int menorTiempo=atleta1.tiempoAtleta();

            if (atleta2.tiempoAtleta()<menorTiempo) 
            {
                menorTiempo = atleta2.tiempoAtleta();
                atletaMenorTiempo = atleta2.nombreAtleta();
            }

            if (atleta3.tiempoAtleta() < menorTiempo)
            {
                menorTiempo = atleta3.tiempoAtleta();
                atletaMenorTiempo = atleta3.nombreAtleta();
            }

            Console.WriteLine("El atleta " + atletaMenorTiempo + " y su tiempo es "+menorTiempo);
        }

        public void SuperarioElPromedio() 
        {
            if (atleta1.tiempoAtleta() < promedio) 
            {
                Console.WriteLine("El atleta " + atleta1.nombreAtleta() + " supero el promedio");
            }

            if (atleta2.tiempoAtleta() < promedio)
            {
                Console.WriteLine("El atleta " + atleta2.nombreAtleta() + " supero el promedio");
            }

            if (atleta3.tiempoAtleta() < promedio)
            {
                Console.WriteLine("El atleta " + atleta3.nombreAtleta() + " supero el promedio");
            }
        }
        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.MuestraDatos();
            c.PromedioTiempo();
            c.MenorTiempo();
            c.SuperarioElPromedio();

            Console.ReadKey();
        }
    }
}
