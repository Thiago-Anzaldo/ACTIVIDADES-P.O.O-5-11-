using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2-
    //Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
    //drones de entrega en vuelo de regreso a la base.
    // Crear la clase Dron que contenga los atributos privados: codigo(string) y
    //nivelBateria(int, de 0 a 100). Definir sus propiedades correspondientes.
    //Su constructor debe recibir cod y bat.
    // Crear la clase CentroControl que administre una lista de objetos
    //List&lt; Dron&gt;.
    // Métodos en CentroControl:

    //1. Un constructor que cargue por teclado una lista inicial de 4 drones
    //ingresando sus códigos y baterías.
    //2. ListarFlota(): Mostrar la lista de drones en pantalla.
    //3. RemoverDronesBajos(): Recorrer la lista y remover por
    //completo de la flota a todos aquellos drones cuyo nivel de batería
    //sea menor o igual al 15% (ya que requieren mantenimiento
    //automático urgente).
    //4. MostrarDronesRestantes() : Imprimir la flota actualizada y la
    //cantidad de drones operativos utilizando la propiedad.Count.
    class Dron 
    {
        private int nivelBateria;
        private string codigo;

        public Dron(string cod, int bat) 
        {
            nivelBateria = bat;
            codigo = cod;
        }

        public int NivelBateria
        {
            get 
            {
                return nivelBateria;
            }
        }
        public string Codigo
        {
            get
            {
                return codigo;
            }
        }

    }
    internal class CentroControl
    {
        List<Dron> Drones = new List<Dron>();

        public CentroControl() 
        {
            string cod;
            int bat;
            string linea;
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el codigo del dron: ");
                cod= Console.ReadLine();

                do
                {
                    Console.WriteLine("ingrese la bateria del dron: ");
                    linea = Console.ReadLine();
                    bat = int.Parse(linea);
                } while (bat>100 || bat<0);

                Drones.Add(new Dron(cod, bat));
            }
        }
        public void ListarFlota() 
        {
            foreach(Dron drons in Drones) 
            {
                Console.Write("codigo: " + drons.Codigo);
                Console.WriteLine(" bateria: " + drons.NivelBateria);
            }
            Console.WriteLine('\n');
        }
        public void RemoverDronesBajos() 
        {
            Drones.RemoveAll(c => c.NivelBateria <=15);
        }
        public void MostrarDronesRestantes() 
        {
            Console.WriteLine("lista actualizada-");
            foreach (Dron drons in Drones)
            {

                Console.Write("codigo" + drons.Codigo);
                Console.WriteLine(" bateria" + drons.NivelBateria);
            }
            Console.WriteLine("drones en flota: "+ Drones.Count); 
        }
        static void Main(string[] args)
        {
            CentroControl cc= new CentroControl();
            cc.ListarFlota();
            cc.RemoverDronesBajos();
            cc.MostrarDronesRestantes();
        }
    }
}
