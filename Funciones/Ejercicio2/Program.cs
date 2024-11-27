// (2) Realizar el mismo ejercicio anterior, pero al pasar a la función los grados Celcius, también se le pasará una “F” para pasar a grados Fahrenheit, o una “K” para pasar a grados Kelvin.

using System;

public class Program{
    public static void Main(string[] args){
        double celcius;
        double K;
        double f;

        Console.Write("Introduce tu temperatura en Celcius: ");
        celcius = Convert.ToDouble(Console.ReadLine());

        Kelvin(celcius, out K);
        Fahrenheit(celcius, out f);


        Console.WriteLine($"En Kevil es {K} y en Fahrenheit {f}");
    }

    private static void Kelvin(double input, out double K){
        K = input + 273.15;
    }

    private static void Fahrenheit(double input, out double f){
        f = input + 32;
    }
    
}