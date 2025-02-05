using System;

public class Program
{
    static void Main(string[] args)
    {
        Puntos p = new Puntos(11, 8);
        Puntos q = new Puntos();
        q.x = 14;
        q.y = 11;
        p.Mostrar('.');
        Console.WriteLine($"\np = {p}");
        Console.WriteLine($"q = {q}");
        Console.WriteLine($"dist(p,q) = {p.distancia(q)}");
    }
}