using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Calificaciones
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
         de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.*/
        private int[] calificaciones;
        private string[] estudiantes;
        public void Carga() 
        {
            estudiantes = new string[6];
            calificaciones = new int[6];
            string linea;

            for (int i = 0; i < calificaciones.Length; i++) 
            {
                Console.Write("ingrese el nombre del estudiante: ");
                estudiantes[i]=Console.ReadLine();


                Console.Write("ingrese la calificacion del estudiante "+estudiantes[i]+": ");
                linea=Console.ReadLine();
                calificaciones[i] = int.Parse(linea);
            }

            for (int i = 0;i < calificaciones.Length; i++) 
            {
                Console.WriteLine("Estudiante: "+estudiantes[i]);
                Console.WriteLine("NOTA: "+ calificaciones[i]);
            }
        }
        public void NotaAlta() 
        {
            int notaAlta = 0;
            string alumnoNotaAlta= "";
            string estudiantesAlta = "";
            bool estudianteConLaMismaNotaAlta = false;

            for (int i = 0; i < 6; i++) 
            {
                if (calificaciones[i] > notaAlta) 
                {
                    notaAlta=calificaciones[i];
                    alumnoNotaAlta = estudiantes[i];
                }
            }

            for (int i = 0; i<6 ; i++) 
            {
                if (calificaciones[i] == notaAlta) 
                {
                    estudiantesAlta +=estudiantes[i]+" ";
                    estudianteConLaMismaNotaAlta=true;
                }
            }
            if (estudianteConLaMismaNotaAlta == true) 
            {
                Console.WriteLine("estudiantes con la nota mas alta como :"+ estudiantesAlta+ "con: "+notaAlta);
            }
                
        }
        public void notaBaja() 
        {   
            bool estudianteConLaMismaNotaBaja=false;
            int notaBaja = calificaciones[0];
            string estudiantesBaja = ""; 
            string alumnoNotaBaja = "";

            for(int i = 1;i<6 ; i++) 
            {
                if (calificaciones[i] <= notaBaja) 
                {
                    notaBaja=calificaciones[i];
                    alumnoNotaBaja=estudiantes[i];
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (calificaciones[i] == notaBaja)
                {
                    estudiantesBaja += estudiantes[i]+" ";
                    estudianteConLaMismaNotaBaja = true;
                }
            }
            if (estudianteConLaMismaNotaBaja == true)
            {
                Console.WriteLine("estudiantes con la nota mas baja: "+ estudiantesBaja+"con: "+ notaBaja);
            }
        }
        static void Main(string[] args)
        {
            Calificaciones c = new Calificaciones();
            c.Carga();
            c.NotaAlta();
            c.notaBaja();
            Console.ReadKey();
        }
    }
}
