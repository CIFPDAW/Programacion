// (5) Crear un programa que pida al usuario 10 números decimales, calcule su media y luego muestre los que están por encima de la media.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        decimal suma, max = 10;
        decimal[] lista = new decimal[max];

        for (int i = 0; i < max; i++)
        {
            Console.Write("Introduce un número: ");
            lista[i] = Convert.ToInt32(Console.ReadLine());
            suma += lista[i];
        }

        decimal resultado = suma / max;

        for (int i = 0; i < max; i++)
        {
            if(lista[i] > resultado){
                Console.Write($" {lista[i]}");
            }
        }
    }
}