using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnergia
{
//    1.
//Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
//CodigoIdentificador(string) y la GeneracionKwh(double, que representa los Kilowatts-hora
//generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
//generación no sea un valor negativo(en caso de serlo, asignarle 0). Plantear un método para
//imprimir estos datos básicos.
//Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
//un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
//en metros cuadrados) con su propiedad correspondiente(validando que sea mayor a cero).
//Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
//En el programa principal (Main):
//● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
//● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
//puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
//muestra de información.
    class DispositivoEnergia
    {
        private string CodigoIdentificador;
        private double GeneracionKwh;

        public string ObtenerCodigo
        {
            set 
            { 
                CodigoIdentificador = value; 
            }
            get
            { 
                return CodigoIdentificador;
            }
        }

        public double ObtenerGeneracion
        {
            set
            {
                if (value < 0)
                {
                    GeneracionKwh = 0;
                }
                else
                {
                    GeneracionKwh = value;
                }
            }
            get 
            { 
                return GeneracionKwh;
            }
        }
        public void muestraBasica()
        {
            Console.WriteLine("codigo identificador: " + CodigoIdentificador);
            Console.WriteLine("generación Kwh: " + GeneracionKwh);
            Console.WriteLine("\n");
        }
    }

    class PanelSolar : DispositivoEnergia
    {
        private double AreaMetros;

        public double ObtenerArea
        {
            set
            {
                if (value > 0)
                {
                    AreaMetros = value; 
                }
            }
            get 
            { 
                return AreaMetros; 
            }
        }

        public void ImprimirDatosPanel()
        {
            Console.WriteLine("codigo identificador: " + ObtenerCodigo);
            Console.WriteLine("generacion kwh: " + ObtenerGeneracion);
            Console.WriteLine("area en metros cuadrados: " + AreaMetros);
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            DispositivoEnergia de = new DispositivoEnergia();
            de.ObtenerCodigo = "asd";
            de.ObtenerGeneracion = 1;


            PanelSolar p = new PanelSolar();

            p.ObtenerCodigo = "dsa";
            p.ObtenerGeneracion = 2;
            p.ObtenerArea = 4;
            p.ImprimirDatosPanel();

            Console.ReadKey();
        }
    }
}
