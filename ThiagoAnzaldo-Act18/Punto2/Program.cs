using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2.
    //Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    //La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    //ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    //propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    //● La profundidad óptima sea estrictamente mayor a cero(0).
    //● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    //asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    //La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    //de la clase CriaturaMarina.Definir un método dentro de HabitatAcuatico para cargar las 3
    //criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    //a su profundidad óptima.Además, el programa debe informar la especie que requiere el mayor
    //nivel de salinidad para sobrevivir.
    class CriaturaMarina
    {
        private string Especie;
        private int ProfundidadOptima;
        private int NivelSalinidad;

        public string ObtenerEspecie
        {
            get
            {
                return Especie;
            }
        }
        public int ObtenerNivelSalinidad
        {
            get
            {
                return NivelSalinidad;
            }
        }
        public int ObtenerProfundidad
        {
            get
            {
                return ProfundidadOptima;
            }
        }
        public CriaturaMarina() 
        {
            string linea;

            Console.Write("ingrese la especie: ");
            Especie=Console.ReadLine();

            Console.Write("nivel de salinidad: ");
            linea=Console.ReadLine();
            if (int.Parse(linea) > 0 && int.Parse(linea) < 100)
            {
                NivelSalinidad = int.Parse(linea);
            }
            else 
            {
                NivelSalinidad = 35;
            }

            int d = 1;
            for (int i = 0; i < d; i++)
            {
                Console.Write("nivel de profundidad: ");
                linea = Console.ReadLine();
                if (int.Parse(linea) > 0)
                {
                    ProfundidadOptima = int.Parse(linea);
                    break;
                }
                d++;
            }
        }
        //public void asd()
        //{
        //    Console.WriteLine(Especie);
        //    Console.WriteLine(NivelSalinidad);
        //    Console.WriteLine(ProfundidadOptima);
        //}
    }
    class HabitatAcuatico
    {
        private CriaturaMarina[] criaturas;

        public HabitatAcuatico() 
        {
            criaturas=new CriaturaMarina[3];
            for (int i = 0; i < 3; i++)
            {
                criaturas[i] = new CriaturaMarina();
            }
        }

        public void MenorAMayorProfundiad() 
        {
            Array.Sort(criaturas, (a, b) => a.ObtenerProfundidad.CompareTo(b.ObtenerProfundidad));
            Console.WriteLine("ORDENADOS DE MENOR A MAYOR SEGUN SU PROFUNDIDAD");
            for(int i = 0; i < 3; i++) 
            {
                Console.WriteLine(i+1+"°");
                Console.WriteLine(criaturas[i].ObtenerEspecie);
                Console.WriteLine(criaturas[i].ObtenerNivelSalinidad);
                Console.WriteLine(criaturas[i].ObtenerProfundidad);
            }
        }
        public void asd()
        {
            string criaturaMayorSalinidad="";
            int MayorSalanidad=0;

            for (int i = 0; i < 3; i++) 
            {
                if (MayorSalanidad<criaturas[i].ObtenerNivelSalinidad) 
                {
                    MayorSalanidad = criaturas[i].ObtenerNivelSalinidad;
                    criaturaMayorSalinidad = criaturas[i].ObtenerEspecie;
                }
            }

            Console.WriteLine("criatura que requiere mayor salinidad: "+criaturaMayorSalinidad);
            Console.WriteLine("salinidad: "+MayorSalanidad);
        }
        static void Main(string[] args)
        {
            HabitatAcuatico ha= new HabitatAcuatico();
            ha.MenorAMayorProfundiad();
            ha.asd();

            Console.ReadKey();
        }
    }
}
