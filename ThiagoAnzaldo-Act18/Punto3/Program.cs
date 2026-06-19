using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //3.
    //Crear una clase base llamada SondaExploradora que contenga los atributos Modelo(string) y
    //AutonomiaMinutos(int). Definir un constructor que reciba estos dos valores como parámetros y
    //realice su asignación.
    //Luego, definir dos clases derivadas de la clase base:
    //● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    //soportada en atmósferas).
    //● RoverTerrestre: que añade el atributo propio CantidadRuedas(int).
    //Cada una de estas clases derivadas debe poseer su propio constructor.El mismo debe recibir
    //tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    //clase SondaExploradora mediante el uso explícito de la palabra clave base.
    //En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    //parámetros unificados por consola.
    internal class SondaExploradora
    {
        private string Modelo;
        private int AutonomiaMinutos;

        public SondaExploradora()
        {
            Console.WriteLine(Modelo);
        }

        public string ObtenerModelo
        {
            set 
            {
                Modelo = value;
            }
            get
            {
                return Modelo;
            }
        }
        public int ObtenerMinutos
        {
            get
            {
                return AutonomiaMinutos;
            }
        }
    }
    class SondaSubmarina : SondaExploradora
    {
        int PresionAtmosferica;

        public SondaSubmarina(string modelo, int presion)
        {
            PresionAtmosferica = presion;
        }
    }
    class RoverTerrestre : SondaExploradora
    {
        int CantidadRuedas;

        public RoverTerrestre(string modelo, int cantidadRuedas) 
        {
            ObtenerModelo = modelo;
            CantidadRuedas= cantidadRuedas;
        }
        static void Main(string[] args)
        {
            //SondaExploradora se = new SondaExploradora("asd");

            SondaSubmarina ss = new SondaSubmarina("asd",2);
        }
    }
}
