using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.
        int num1, num2, num3, suma, producto;
        string linea;

        Console.Write("El primer numero: ");
        linea = Console.ReadLine()!;
        num1 = int.Parse(linea);

        Console.Write("El segundo numero: ");
        linea = Console.ReadLine()!;
        num2 = int.Parse(linea);

        Console.Write("El tercer numero: ");
        linea = Console.ReadLine()!;
        num3 = int.Parse(linea);

        if(num1==num2 && num2==num3)
        {
            suma = num1 + num2;
            producto = suma * num3;
            Console.WriteLine("El resultado es: " + producto);
        }

        Console.ReadKey();
    }
}