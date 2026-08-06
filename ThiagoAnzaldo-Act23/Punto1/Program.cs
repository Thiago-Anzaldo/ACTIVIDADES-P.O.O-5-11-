using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            string nom;
            int pag;
            string linea;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("ingrese el nombre del documento: ");
                nom = Console.ReadLine();
                Console.Write("ingrese la cantidad de paginas: ");
                linea = Console.ReadLine();
                pag = int.Parse(linea);

                documentos.Add(new Documento(nom, pag));
            }
        }
        public void ImprimirSiguiente() 
        {
            foreach (Documento documento in documentos)
            {
                Console.Write(documento.nombreArchivo, documento.cantidadPaginas);
                Console.WriteLine(documento.cantidadPaginas);

                documentos.RemoveAt(0);
            }
        }

        //public void MostrarColaPendiente() 
        //{
        //    for(int i=0; i<documentos.Count; i++) 
        //    {
        //        Console.Write(documentos);
        //    }
        //}
        static void Main(string[] args)
        {
            ServidorImpresion si= new ServidorImpresion();
            si.AgregarDocumento();
            si.ImprimirSiguiente();
            //si.MostrarColaPendiente();
            Console.ReadKey();
        }
    }
}
