// (3) Solicitar 10 números distintos por teclado y mostrarlos.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] lista = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Dame un numero: ");
            lista[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            Console.Write($" {lista[i]}");
        }
    }
}