using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Punto1
{
    //1-
    //En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
    //llegada.
    // Crear la clase Documento que contenga como atributos privados:
    //nombreArchivo(string) y cantidadPaginas(int). Definir sus
    //propiedades de solo lectura y un constructor que reciba los parámetros nom
    //y pag.
    // Crear la clase ServidorImpresion que administre una lista dinámica de
    //documentos (List&lt; Documento&gt;).
    // Métodos en ServidorImpresion:
    //1. AgregarDocumento() : Solicitar por teclado los datos de un
    //documento y agregarlo al final de la lista utilizando.Add().
    //2. ImprimirSiguiente() : Si la lista no está vacía, simular la
    //impresión del primer documento de la lista(mostrar sus datos en
    //consola) y removerlo de la colección mediante.RemoveAt(0). Si está
    //vacía, advertir que no hay trabajos pendientes.
    //3. MostrarColaPendiente(): Listar todos los documentos que
    //están esperando ser impresos y la cantidad total de páginas
    //acumuladas en la cola de espera utilizando .Count.
    class Documento
    {
        public string nombreArchivo;
        public int cantidadPaginas;


        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }
    class ServidorImpresion
    {
        List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            Console.Clear();
            string nom;
            int pag;
            string linea;

            for (int i = 0; i < 1; i++)
            {
                Console.Write("ingrese el nombre del documento: ");
                nom = Console.ReadLine();
                Console.Write("ingrese la cantidad de paginas: ");
                linea = Console.ReadLine();
                pag = int.Parse(linea);

                documentos.Add(new Documento(nom, pag));
            }
            Console.Clear();
        }
        public void ImprimirSiguiente()
        {
            Console.Clear();
            if (documentos.Count < 1)
            {
                Console.WriteLine("No hay trabajos pendientes");
                Console.WriteLine("aprete Enter para seguir");
                Console.ReadLine();
                //Thread.Sleep(1000);
            }
            else
            {
                Console.Write("Nombre del archivo: " + documentos[0].nombreArchivo);
                Console.WriteLine(" Cantidad de paginas del archivo: " + documentos[0].cantidadPaginas);

                documentos.RemoveAt(0);
                //Thread.Sleep(1000);
                Console.WriteLine("aprete Enter para seguir");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void MostrarColaPendiente()
        {
            int totalPags = 0;
            Console.Clear();
            if (documentos.Count < 1)
            {
                Console.WriteLine("No hay trabajos pendientes");
                Console.WriteLine("aprete Enter para seguir");
                Console.ReadLine();
                //Thread.Sleep(1000);
            }
            else
            {
                for (int i = 0; i < documentos.Count; i++)
                {
                    Console.Write((i + 1) + "° Nombre del archivo: " + documentos[i].nombreArchivo);
                    Console.WriteLine(" Cantidad de paginas del archivo: " + documentos[i].cantidadPaginas);

                    totalPags = totalPags + documentos[i].cantidadPaginas;

                }
                Console.WriteLine('\n');
                Console.WriteLine("total de paginas: " + totalPags);
                //Thread.Sleep(1000);
                Console.WriteLine("aprete Enter para seguir");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
            ServidorImpresion si = new ServidorImpresion();

            string linea;
            int opcion;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("que funcion quiere realizar: ");
                Console.WriteLine("1.Agregar documento");
                Console.WriteLine("2.Imprimir el siguiente documento");
                Console.WriteLine("3.Mostrar cola pendiente de archivos");
                linea = Console.ReadLine();

                if (linea != "1" && linea != "2" && linea != "3")
                {
                    Console.WriteLine("ingrese un numero segun la funcion");
                    Thread.Sleep(1000);
                }
                else
                {
                    opcion = int.Parse(linea);
                    if (opcion == 1)
                    {
                        si.AgregarDocumento();
                    }
                    else if (opcion == 2)
                    {
                        si.ImprimirSiguiente();
                    }
                    else if (opcion == 3)
                    {
                        si.MostrarColaPendiente();
                    }
                    Console.Clear();
                }
            }

        }
    }
}
