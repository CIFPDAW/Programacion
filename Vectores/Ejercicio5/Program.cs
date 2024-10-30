// (5) Crear un programa que pida al usuario 10 números floates, calcule su media y luego muestre los que están por encima de la media.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        float suma = 0;
        int max = 10;
        float[] lista = new float[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("Introduce un número: ");
            lista[i] = Convert.ToSingle(Console.ReadLine());
            suma += lista[i];
        }

        float resultado = suma / max;
        Console.WriteLine($"La media es: {resultado}");

        for (int i = 0; i < max; i++)
        {
            if(lista[i] > resultado){
                Console.Write($" {lista[i]}");
            }
        }
    }
}