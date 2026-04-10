using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            finalizar al ingresar un valor negativo en el número de cuenta.
            Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            informe:
            a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            que:
            Estado de la cuenta:
                ○ “Acreedor” si el saldo es > 0.
                ○ “Deudor” si el saldo es < 0.
                ○ “Nulo” si el saldo es = 0.
            b) La suma total de los saldos acreedores.*/

            int numeroDeCuenta, sueldo, sumaAcreedores;
            string linea;
            bool corte;
            int i = 0;
            corte = true;
            sumaAcreedores = 0;
            do
            {
                Console.Write("Numero de cliente: ");
                linea= Console.ReadLine();
                numeroDeCuenta = int.Parse(linea);

                if (numeroDeCuenta<0)
                {
                    corte = false;
                }
                else
                {
                    Console.Write("Sueldo: $");
                    linea = Console.ReadLine();
                    sueldo=int.Parse(linea);

                    if (sueldo > 0)
                    {
                        Console.WriteLine( "Acreedor");
                        sumaAcreedores=sumaAcreedores+sueldo;
                    }
                    else if (sueldo<0)
                    {
                        Console.WriteLine("Adeudor");
                    }
                    else {
                        Console.WriteLine("Nulo");
                    }
                }
                i++;
            } while (corte == true);

            Console.WriteLine("La suma de todos los sueldos de los acreedores es: $" + sumaAcreedores);
            Console.ReadKey();
        }
    }
}
