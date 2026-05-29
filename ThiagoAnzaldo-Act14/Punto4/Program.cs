using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
//    4. Inventario de Sucursales
//Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual.El constructor de la clase debe cargar estos atributos por teclado.
//Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
//Implementar en la clase Sucursal los siguientes métodos:
//Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio* Stock).
//Un método que busque y muestre el nombre del artículo más caro del local.
//Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

    class Articulo
    {
        private int stockActual;
        private string nombreArticulo;
        private double precio;
        public Articulo() 
        {
            string linea;
            Console.Write("Ingrese el nombre del articulo: ");
            nombreArticulo = Console.ReadLine();

            Console.Write("Ingrese el precio del articulo: $");
            linea=Console.ReadLine();
            precio=double.Parse(linea);

            Console.Write("Ingrese el stock del articulo: ");
            linea = Console.ReadLine();
            stockActual = int.Parse(linea);
        }

        public int stock() 
        {
            return stockActual;
        }
        public string nombre()
        {
            return nombreArticulo;
        }
        public double precioArticulo()
        {
            return precio;
        }
    }
    class Sucursal
    {
        private Articulo[] articulos;

        public Sucursal() 
        {
            articulos = new Articulo[3];
            for(int i = 0; i < 3; i++) 
            {
                articulos[i]=new Articulo();
            }
        }

        public void MuestraArticulos() 
        {
            double valorTotal = 0;

            for(int i = 0; i < 3; i++) 
            {
                valorTotal = articulos[i].precioArticulo() * articulos[i].stock();
                Console.WriteLine("El articulo " + articulos[i].nombre()+" tiene un valor de "+valorTotal);
                Console.WriteLine("\n");
                valorTotal = 0;
            }
        }

        public void ProductoMasCaro() 
        {
            double productoCaro = 0;
            string articuloCaro = "";

            for(int i = 0; i < 3; i++) 
            {
                if (articulos[i].precioArticulo() > productoCaro) 
                {
                    productoCaro=articulos[i].precioArticulo();
                    articuloCaro=articulos[i].nombre();
                }
            }
            Console.WriteLine("El articulo mas caro es: " + articuloCaro);
            Console.WriteLine("valiendo: $"+ productoCaro);
            Console.WriteLine("\n");
        }

        public void RequiereStock() 
        {
            for (int i=0;i<3;i++) 
            {
                if (articulos[i].stock() < 5) 
                {
                    Console.WriteLine("El articulo " + articulos[i].nombre()+" requiere una reposicion urgente");
                }
            }
        }

        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.MuestraArticulos();
            s.ProductoMasCaro();
            s.RequiereStock();
            Console.ReadKey();
        }
    }
}
