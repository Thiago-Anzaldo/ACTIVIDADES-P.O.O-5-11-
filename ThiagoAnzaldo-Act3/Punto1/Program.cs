using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //1.Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
        int dia, mes, año;
        string linea;

        Console.Write("ingrese un dia: ");
        linea = Console.ReadLine()!;
        dia = int.Parse(linea);

        Console.Write("ingrese un mes: ");
        linea = Console.ReadLine()!;
        mes = int.Parse(linea);

        Console.Write("ingrese un año: ");
        linea = Console.ReadLine()!;
        año = int.Parse(linea);

        if(dia == 25 && mes == 12)
        {
            Console.WriteLine("FELIZ NAVIDAD!!!");
            Console.WriteLine(dia); Console.WriteLine(mes); Console.WriteLine(año);
        }
        Console.ReadKey();
    }
}