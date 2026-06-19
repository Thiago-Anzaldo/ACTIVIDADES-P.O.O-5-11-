using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEnergia
{
    class DispositivoEnergia
    {
        private protected string CodigoIdentificador;
        private protected double GeneracionKwh;

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
            Console.WriteLine("codigo identificador: " + CodigoIdentificador);
            Console.WriteLine("generacion kwh: " + GeneracionKwh);
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
