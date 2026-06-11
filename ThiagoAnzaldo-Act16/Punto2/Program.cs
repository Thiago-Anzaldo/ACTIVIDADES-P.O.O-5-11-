using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Plantear una clase Producto y otra clase Inventario.
    //La clase Producto debe tener como atributos privados el nombre, precio y
    //stock.Definir propiedades para acceder a estos atributos, asegurando que el
    //stock no pueda ser negativo y el precio sea mayor a cero.
    //La clase Inventario debe contener 3 objetos de la clase Producto.Definir un
    //método para mostrar todos los productos ordenados de menor a mayor en
    //base al precio, además, mostrar el producto más caro y más barato del
    //inventario.

    class Producto 
    {
        private string nombre;
        private int stock;
        private float precio;

        public string Nombre 
        {
            set 
            {
                nombre = value;
            }
            get 
            {
                return nombre;
            }
        }
        public int Stock 
        {
            set 
            {
                stock = value;
            }
            get 
            {
                return stock;
            }
        }
        public float Precio
        {
            set
            {
                    precio = value;
            }
            get
            {
                return precio;
            }
        }
    } 
    class Inventario
    {
        private float[] productos;
        private Producto p1, p2, p3;

        public Inventario() 
        {
            p1 = new Producto();
            p2 = new Producto();
            p3 = new Producto();
        }

        public void IngresoDatos()
        {

            string linea;
            Console.Write("Nombre del producto: ");
            p1.Nombre=Console.ReadLine();
            do
            {
                Console.WriteLine("ingrese el stock: ");
                linea = Console.ReadLine();
                p1.Stock = int.Parse(linea);
            }
            while (p1.Stock < 0);
            do {
                Console.WriteLine("ingrese el precio: ");
                linea = Console.ReadLine();
                p1.Precio = float.Parse(linea);
            }
            while (p1.Precio < 1);

            Console.Write("Nombre del producto: ");
            p2.Nombre = Console.ReadLine();
            do
            {
                Console.WriteLine("ingrese el stock: ");
                linea = Console.ReadLine();
                p2.Stock = int.Parse(linea);
            }
            while (p2.Stock < 0);
            do
            {
                Console.WriteLine("ingrese el precio: ");
                linea = Console.ReadLine();
                p2.Precio = float.Parse(linea);
            }
            while (p2.Precio < 1);

            Console.Write("Nombre del producto: ");
            p3.Nombre = Console.ReadLine();
            do
            {
                Console.WriteLine("ingrese el stock: ");
                linea = Console.ReadLine();
                p3.Stock = int.Parse(linea);
            }
            while (p3.Stock < 0);
            do
            {
                Console.WriteLine("ingrese el precio: ");
                linea = Console.ReadLine();
                p3.Precio = float.Parse(linea);
            }
            while (p3.Precio < 1);
        }

        public void MayorAMenor() 
        {
            Producto[] lista = new Producto[3];
            lista[0] = p1;
            lista[1] = p2;
            lista[2] = p3;

            Array.Sort(lista, (a, b) => a.Precio.CompareTo(b.Precio));

            Console.WriteLine("Primer puesto: "+ lista[0].Nombre +" Precio: "+ lista[0].Precio);
            Console.WriteLine("Segundo puesto: " + lista[1].Nombre + " Precio: " + lista[1].Precio);
            Console.WriteLine("Tercer puesto: " + lista[2].Nombre + " Precio: " + lista[2].Precio);

            Console.WriteLine("mas barato: " + lista[0].Nombre + " Precio: " + lista[0].Precio)
            Console.WriteLine("mas caro: " + lista[0].Nombre + " Precio: " + lista[0].Precio);
        }
        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.IngresoDatos();
            i.MayorAMenor();
        }
    }
}
