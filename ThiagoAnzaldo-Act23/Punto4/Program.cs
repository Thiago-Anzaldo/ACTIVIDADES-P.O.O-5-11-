using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //4-
    //Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
    //vinculados a una red hogareña.
    // Crear la clase DispositivoInteligente que contenga como atributos
    //privados: nombreDispositivo(string) y consumoWatts(double). Definir
    //sus propiedades y un constructor que reciba nom y watts.
    // Crear la clase colaboradora PanelDomotico que administre un objeto
    //List&lt;DispositivoInteligente&gt;.
    // Métodos en PanelDomotico:
    //1. Un constructor que permita al usuario cargar dinámicamente
    //dispositivos por teclado.El sistema preguntará después de cada
    //carga si se desea agregar otro dispositivo.
    //2. MostrarDispositivos(): Listar todos los dispositivos
    //configurados junto a sus consumos.
    //3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
    //Watts totales que consume la casa sumando los valores de la lista.
    //4. DesconectarDispositivo(): Solicitar al usuario el nombre de
    //un dispositivo y, si existe en la lista, removerlo de forma dinámica
    //para simular su apagado remoto.
    class DispostivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;
        public DispostivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }

        public string NombreDispositivo
        {
            get
            {
                return nombreDispositivo;
            }
        }
        public double ConsumoWatts
        {
            get
            {
                return consumoWatts;
            }
        }
    }

    internal class PanelDomotico
    {
        List<DispostivoInteligente> dispositivos = new List<DispostivoInteligente>();

        public PanelDomotico()
        {
            double watts;
            string nom;
            string linea;
            string respuesta;

            while (true)
            {
                do {
                    Console.Write("ingrese el nombre del dispositivo: ");
                    nom = Console.ReadLine();
                } while (nom=="");

                do {
                    Console.WriteLine("cuantos watts consume: ");
                    linea = Console.ReadLine();
                } while (linea=="");
                    watts = double.Parse(linea);
                dispositivos.Add(new DispostivoInteligente(nom, watts));

                do
                {
                    Console.WriteLine("quiere agregar un nuevo dispositivo? (si o no)");
                    respuesta = Console.ReadLine();
                } while (respuesta != "si"&& respuesta!="no");

                if (respuesta == "no")
                {
                    break;
                }
            }
        }

        public void MostrarDispositivos()
        {
            Console.WriteLine("lista de dispositivos:");
            foreach (DispostivoInteligente disp in dispositivos)
            {
                Console.WriteLine(disp.NombreDispositivo);
            }
        }
        public void CalcularConsumoTotal()
        {
            double wattsTotales = 0;
            foreach (DispostivoInteligente disp in dispositivos)
            {
                wattsTotales = wattsTotales + disp.ConsumoWatts;
            }
            Console.WriteLine("total de watts");
            Console.WriteLine(wattsTotales);
        }
        public void DesconectarDispositivo()
        {
            string busquedaDispositivo;

            Console.WriteLine("ingrese el dispositivo que quiere encontrar: ");
            busquedaDispositivo = Console.ReadLine();

            foreach (DispostivoInteligente disp in dispositivos)
            {

                if (disp.NombreDispositivo == busquedaDispositivo)
                {
                    Console.WriteLine("dispotivo desconectado");
                    dispositivos.Remove(disp);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            PanelDomotico pd = new PanelDomotico();
            pd.MostrarDispositivos();
            pd.CalcularConsumoTotal();
            pd.DesconectarDispositivo();
        }
    }
}