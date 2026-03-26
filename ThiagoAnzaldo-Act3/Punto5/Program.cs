using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //5. Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0). 

        int x, y;
        string linea;

        Console.Write("Ingrese la coordenada x (distinta de 0): ");
        linea = Console.ReadLine()!;
        x = int.Parse(linea);

        Console.Write("Ingrese la coordenada y (distinta de 0): ");
        linea = Console.ReadLine()!;
        y = int.Parse(linea);

        if (x != 0 && y != 0) {

            if (x > 0 && y > 0)
            {
                Console.WriteLine("esta en el 1º Cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("esta en el 2º Cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("esta en el 3º Cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("esta en el 4º Cuadrante");
            }
        }
        else
        {
            Console.WriteLine("ingrese un numero distinto de 0");
        }
        Console.ReadKey();
    }
}