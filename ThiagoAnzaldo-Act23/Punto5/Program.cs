using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto5
{
    //    5-
    //Un taller mecánico automatizado administra la recepción y egreso de automóviles
    //que se encuentran en el sector de reparaciones.
    // Crear la clase Vehiculo que contenga como atributos privados: patente
    //(string) y costoReparacion(double). Definir sus propiedades
    //correspondientes y un constructor que reciba pat y costo.
    // Crear la clase GestionTaller que administre una lista de objetos List.
    // Métodos en GestionTaller:
    //o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
    //reparación de un vehículo para agregarlo a la lista mediante.Add().
    //o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
    //recorriendo la lista, informar si el vehículo está en el taller y mostrar
    //su costo asociado.
    //o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
    //vehículo en la lista y, si existe, removerlo de la colección mediante
    //.Remove() confirmando la entrega del automóvil.

    //o CalcularRecaudacionPendiente(): Listar los vehículos
    //actualmente en reparación, la cantidad total de unidades alojadas en
    //el taller mediante la propiedad .Count y la suma total acumulada por
    //cobrar.
    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public Vehiculo(string pat, double costo)
        {
            patente = pat;
            costoReparacion = costo;
        }

        public double CostoReparacion
        {
            get
            {
                return costoReparacion;
            }
        }
        public string Patente
        {
            get
            {
                return patente;
            }
        }
    }
    internal class GestionTaller
    {
        List<Vehiculo> autos = new List<Vehiculo>();

        public void IngresarVehiculo() 
        {
            double costo;
            string pat;
            string linea;

            Console.Write("ingrese la patente del auto:");
            pat = Console.ReadLine();

            Console.Write("ingrese la costo del auto: ");
            linea=Console.ReadLine();
            costo=double.Parse(linea);
                
            autos.Add(new Vehiculo(pat, costo));
        }

        public void BucarVehiculo() 
        {
            string opcion;

            Console.Write("ingrese que vehiculo quiere buscar:");
            opcion=Console.ReadLine();

            foreach (Vehiculo ve in autos) 
            {
                if (opcion == ve.Patente) 
                {
                    Console.WriteLine("su vehiculo si esta en el taller y cuesta "+ ve.CostoReparacion);
                    break;
                }
                else 
                {
                    Console.WriteLine("no se encontro su auto");
                }
            }
            Console.WriteLine("aprete Enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }
        public void EntregarVehiculo() 
        {
            string opcion;

            Console.WriteLine("ingrese la patente del vehiculo para entregar: ");
            opcion= Console.ReadLine();

            foreach (Vehiculo ve in autos) 
            {
                if(opcion == ve.Patente) 
                {
                    autos.Remove(ve);
                    Console.WriteLine("se encontro su auto");
                    break;
                }
                else 
                {
                    Console.WriteLine("no se encontro su auto");
                }
            }
            Console.WriteLine("aprete Enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }
        public void CalcularRecaudacionPendiente() 
        {
            double sumaTotal=0;
            foreach(Vehiculo ve in autos) 
            {
                Console.Write("patente de auto "+ve.Patente+" ");
                Console.WriteLine("costo de auto "+ve.CostoReparacion);

                sumaTotal = sumaTotal + ve.CostoReparacion;
            }
            Console.WriteLine("total de autos: "+autos.Count());
            Console.WriteLine("total de costo: "+sumaTotal);
            Console.WriteLine("aprete Enter para seguir");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            GestionTaller gt = new GestionTaller();

            string linea;
            int opcion;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("que funcion quiere realizar: ");
                Console.WriteLine("1.Agregar vehiculo");
                Console.WriteLine("2.Buscar");
                Console.WriteLine("3.entrega");
                Console.WriteLine("4.calcular");
                Console.WriteLine("5.terminar");
                linea = Console.ReadLine();

                if (linea != "1" && linea != "2" && linea != "3" && linea != "4" && linea != "5")
                {
                    Console.WriteLine("ingrese un numero segun la funcion");
                    Thread.Sleep(1000);
                }
                else
                {
                    opcion = int.Parse(linea);
                    if (opcion == 1)
                    {
                        gt.IngresarVehiculo();
                    }
                    else if (opcion == 2)
                    {
                        gt.BucarVehiculo();
                    }
                    else if (opcion == 3)
                    {
                        gt.EntregarVehiculo();
                    }
                    else if (opcion == 4)
                    {
                        gt.CalcularRecaudacionPendiente();
                    }
                    else if (opcion == 5) 
                    {
                        break;
                    }
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
