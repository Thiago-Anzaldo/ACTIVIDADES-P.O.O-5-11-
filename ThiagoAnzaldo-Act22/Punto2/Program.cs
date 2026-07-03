using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Actividad 2: Posicionamiento de elementos en consola
    //Problema:
    //Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
    // Implementar propiedades y un constructor que cargue valores.
    // Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    //nombre en pantalla y Console.CursorVisible para ocultar el cursor.
    // Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    //consola.
    internal class ElementoPantalla
    {
        private int posX;
        private int posY;
        private string nombre;

        public ElementoPantalla(int posX, int posY, string nombre)
        {
            this.posX = posX;
            this.posY = posY;
            this.nombre = nombre;
        }

        public void Mostrar() 
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write(nombre);
            Console.CursorVisible = false;
        }
        static void Main(string[] args)
        {
            ElementoPantalla[] elementos= new ElementoPantalla[4];

            elementos[0] = new ElementoPantalla(10, 5, "elemento 1");
            elementos[1]= new ElementoPantalla(20, 10, "elemento 2");
            elementos[2]= new ElementoPantalla(30, 15, "elemento 3");
            elementos[3]= new ElementoPantalla(40, 20, "elemento 4");

            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i].Mostrar();
            }

            Console.ReadKey();
        }
    }
}
