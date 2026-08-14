using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{
    //7-
    //Un restaurante automatizado procesa la comanda de una mesa para controlar la
    //preparación y el cobro de los platos pedidos.
    // Crear la clase Plato que contenga como atributos privados: nombrePlato
    //(string) y precio (double). Definir sus propiedades correspondientes y un
    //constructor que reciba nom y pre.
    // Crear la clase GestionComandas que administre una lista de objetos List.
    // Métodos en GestionComandas:
    //o AgregarPlato():Solicitar por teclado los datos de un plato y
    //agregarlo a la lista utilizando .Add().
    //o MostrarComanda(): Listar todos los platos agregados hasta el
    //momento junto a la cantidad total de ítems pedidos utilizando la
    //propiedad.Count.
    //o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
    //total a cobrar sumando los precios de la lista.
    //o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
    //se encuentra en la lista, removerlo mediante .Remove() para
    //actualizar la comanda.
    class Plato
    {
        private string nombrePlato;
        private double precio;

        public Plato(string nom, double pre)
        {
            nombrePlato = nom;
            precio = pre;
        }

        public string NombrePlato
        {
            get
            {
                return nombrePlato;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }
        }
    }
    internal class GestionComandas
    {
        List<Plato> platos = new List<Plato>();

        public void AgregarPlato()
        {
            string linea;
            string nom;
            double pre;
            while (true)
            {
                Console.Write("ingrese el nombre del plato (ponga 'FIN' para finalizar la carga): ");
                nom = Console.ReadLine();

                if (nom == "FIN")
                {
                    break;
                }

                Console.Write("ingrese el precio del plato: ");
                linea = Console.ReadLine();
                pre = double.Parse(linea);

                platos.Add(new Plato(nom, pre));
            }
        }

        public void MostrarComanda()
        {
            foreach (Plato pla in platos)
            {
                Console.WriteLine(pla.NombrePlato);
            }

            Console.WriteLine("la cantidad de platos que hay: " + platos.Count());
        }
        public void CalcularTotalMesa()
        {
            double monto = 0;
            foreach (Plato pla in platos)
            {
                monto = monto + pla.Precio;
            }
            Console.WriteLine("monto: " + monto);
        }
        public void CancelarPlato()
        {
            string platoEliminar;

            Console.Write("escriba el nombre del plato que quiere eliminar: ");
            platoEliminar = Console.ReadLine();

            for (int i = 0; i < platos.Count; i++)
            {
                if (platos[i].NombrePlato == platoEliminar)
                {
                    platos.Remove(platos[i]);
                }
            }
            Console.WriteLine("nueva lista--------------------------------------");
            foreach (Plato pla in platos)
            {
                Console.WriteLine(pla.NombrePlato);
            }

        }
        static void Main(string[] args)
        {
            GestionComandas gc = new GestionComandas();
            gc.AgregarPlato();
            gc.MostrarComanda();
            gc.CalcularTotalMesa();
            gc.CancelarPlato();

            Console.ReadKey();
        }
    }
}
