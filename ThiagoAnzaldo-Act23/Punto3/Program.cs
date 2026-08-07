using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Punto3
{
    //3-
    //Un centro de conservación marina registra de forma dinámica las especies de
    //mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
    // Crear la clase MonitoreoCostero que contenga como atributo privado
    //una lista de cadenas de texto List&lt; string&gt; especiesDetectadas.
    // Métodos en MonitoreoCostero:
    //1. CargarAvistamientos() : Solicitar por teclado nombres de
    //especies marinas avistadas(ej: &quot; Ballena Franca&quot;, &quot;Lobo Marino&quot;,
    //&quot;Delfín&quot;) y agregarlos a la lista utilizando.Add(). La carga finaliza
    //cuando el usuario ingresa la palabra & quot; FIN&quot;.
    //2. MostrarReporteOrdenado() : Imprimir la lista de avistamientos
    //organizada alfabéticamente de la A a la Z utilizando el método
    //.Sort().
    //3. MostrarReporteInvertido() : Imprimir la lista organizada de la
    //Z a la A combinando.Sort() con el método.Reverse().
    //4. BuscarEspecie() : Pedir al operador que ingrese el nombre de un
    //animal y, utilizando los métodos de búsqueda de listas, informar si la
    //especie fue divisada en la costa durante el día.
    internal class MonitoreoCostero
    {
        private List<string> especiesDetectadas = new List<string>();

        public void CargarAvistamientos()
        {
            string linea;
            while (true)
            {
                Console.WriteLine("ingrese la especie marina avistada: ");
                linea = Console.ReadLine();

                if (linea != "FIN")
                {
                    especiesDetectadas.Add(linea);
                }
                else
                {
                    break;
                }
            }
        }
        public void MostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();
            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
        }
        public void MostrarReporteInvertido() 
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            foreach (string especie in especiesDetectadas)
            {
                Console.WriteLine(especie);
            }
            especiesDetectadas.Reverse();
        }
        public void BuscarEspecie() 
        {
            string animal;
            Console.Write("ingrese el nombre de un animal: ");
            animal=Console.ReadLine();

            string animalEncontrado = especiesDetectadas.Find(x => x == animal);

            if (animalEncontrado != null)
            {
                Console.WriteLine(especiesDetectadas.Find(x => x == animal));
            }
            else 
            { 
                Console.WriteLine("no se encontro");
            }
        }
        static void Main(string[] args) 
        {
            MonitoreoCostero mc = new MonitoreoCostero();
            mc.CargarAvistamientos();
            mc.MostrarReporteOrdenado();
            mc.MostrarReporteInvertido();
            mc.BuscarEspecie();
            Console.ReadKey();
        }
    }
}
