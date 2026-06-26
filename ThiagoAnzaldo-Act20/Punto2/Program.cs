using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Actividad 2: Administración de entregas logísticas
    //Problema:
    //Una empresa de envíos desea registrar sus entregas mediante colaboración de
    //clases.
    //Crear una clase Paquete con propiedades: código, peso y destino.Crear una clase
    //Despachador que contenga una lista de paquetes y un método para registrar nuevos
    //paquetes.
    //Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
    // Todos los paquetes registrados.
    // Cuántos superan los 10 kg de peso.
    // Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    class Paquete
    {
        protected int codigo;
        protected double peso;
        protected string destino;

        public Paquete(int cod, double pes, string dest)
        {
            codigo = cod;
            peso = pes;
            destino = dest;
        }

        public string Destino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }
        public int Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public double Peso
        {
            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }
    }
    class Despachador
    {
        private Paquete paq;
        List<Paquete> listaPaquetes = new List<Paquete>();

        public void cargaDespachador(int cod, double pes, string dest)
        {
            paq = new Paquete(cod, pes, dest);
            paq.Codigo = cod;
            paq.Peso = pes;
            paq.Destino = dest;

            Paquete p = new Paquete(cod, pes, dest);
            listaPaquetes.Add(p);
        }

        public void ListaMuestra()
        {
            foreach (Paquete d in listaPaquetes)
            {
                Console.Write("codigo: " + d.Codigo + " ||");
                Console.Write("peso del paquete: " + d.Peso + "|| ");
                Console.WriteLine("destino del paquete: " + d.Destino + " ");
            }
        }

        public void MayorA10Kilos()
        {
            foreach (Paquete d in listaPaquetes)
            {
                if (d.Peso > 10)
                {
                    Console.Write("el paquete " + d.Codigo + " ");
                    Console.WriteLine("pesa mas que 10 kilos");
                }
            }
        }

        public void DestinosNacionales(string dest)
        {
            foreach (Paquete d in listaPaquetes)
            {
                if (d.Destino == dest)
                {
                    Console.WriteLine("el paquete " + d.Codigo + " tiene destino a " + dest);
                }
            }
        }
        static void Main(string[] args)
        {
            Despachador d = new Despachador();
            int cod = 1;
            double pes = 2.3;
            string dest = "argentina";
            d.cargaDespachador(cod, pes, dest);

            cod = 2;
            pes = 3.3;
            dest = "colombia";
            d.cargaDespachador(cod, pes, dest);

            cod = 3;
            pes = 0.3;
            dest = "costa rica";
            d.cargaDespachador(cod, pes, dest);


            cod = 4;
            pes = 17.3;
            dest = "ecuador";
            d.cargaDespachador(cod, pes, dest);

            cod = 5;
            pes = 11.3;
            dest = "argentina";
            d.cargaDespachador(cod, pes, dest);

            d.ListaMuestra();
            d.MayorA10Kilos();
            string destinoNacional = "argentina";
            d.DestinosNacionales(destinoNacional);

            Console.ReadKey();
        }
    }
}