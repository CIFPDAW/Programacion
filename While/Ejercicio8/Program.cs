﻿// (8) Imprimir y contar el número de múltiplos de tres que existen desde el 1 a un número solicitado por teclado.
using System;

public class Program{
    public static void Main(string[] args){
        int num, suma = 1;
        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        while (suma < num){
            Console.WriteLine(suma);
            suma += 1;
        }
    }
}