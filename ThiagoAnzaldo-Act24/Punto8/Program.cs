using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    //8-
    //Una farmacia controla el nivel de stock de sus medicamentos para evitar el
    //desabastecimiento de insumos esenciales.
    // Crear la clase Medicamento que contenga los atributos privados: nombre
    //(string) y stock(int). Definir sus propiedades correspondientes.Su
    //constructor debe recibir nom y stk.
    // Crear la clase ControlFarmacia que administre una lista de objetos List.
    // Métodos en ControlFarmacia:
    //o Un constructor que cargue por teclado una lista inicial de 4
    //medicamentos ingresando sus nombres y stock.
    //o ListarStock(): Mostrar la lista de medicamentos en pantalla.

    //o RemoverAgotados(): Recorrer la lista y remover por completo de
    //la colección a todos aquellos medicamentos cuyo stock sea igual a 0.
    //o MostrarMedicamentosDisponibles(): Imprimir la lista
    //actualizada y la cantidad de productos disponibles en el inventario
    //utilizando la propiedad .Count.

    class Medicamento
    {
        private string nombre;
        private int stock;

        public Medicamento(string nom, int stk)
        {
            nombre = nom;
            stock = stk;
        }

        public string Nombre { get { return nombre; } }
        public int Stock { get { return stock; } }
    }
    internal class ControlFarmacia
    {
        List<Medicamento> medicamentos = new List<Medicamento>();
        public ControlFarmacia()
        {
            string linea;
            string nom;
            int stk;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese el nombre del medicamento: ");
                nom = Console.ReadLine();

                Console.WriteLine("ingrese su stock: ");
                linea = Console.ReadLine();
                stk = int.Parse(linea);

                medicamentos.Add(new Medicamento(nom, stk));
            }
        }

        public void ListarStock()
        {
            Console.WriteLine("LISTA INICIAL---------------");

            foreach (Medicamento medi in medicamentos)
            {
                Console.WriteLine(medi.Nombre);
            }
        }

        public void RemoverAgotados()
        {
            for (int i = 0; i < medicamentos.Count; i++)
            {
                if (medicamentos[i].Stock <= 0)
                {
                    medicamentos.Remove(medicamentos[i]);
                }
            }
        }
        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("LISTA ACTUALIZADA---------------");
            foreach (Medicamento medi in medicamentos)
            {
                Console.WriteLine(medi.Nombre);
            }
            Console.WriteLine("cantida de medicamentos: " + medicamentos.Count);
        }
        static void Main(string[] args)
        {
            ControlFarmacia cf = new ControlFarmacia();
            cf.ListarStock();
            cf.RemoverAgotados();
            cf.MostrarMedicamentosDisponibles();
            Console.ReadKey();
        }
    }
}
