using System;
using herencia;

public class Program
{
    public static void Main(string[] args)
    {
        List<AsistenteDeCabina> Asistentes = new List<AsistenteDeCabina>();
        AsistenteDeCabina Asistente1 = new AsistenteDeCabina("Daniel", 26, "Darias", 12);
        Asistentes.Add(Asistente1);
        AsistenteDeCabina Asistente2 = new AsistenteDeCabina("Darias", 18, "Daniel", 1);
        Asistentes.Add(Asistente2);
        AsistenteDeCabina Asistente3 = new AsistenteDeCabina("Jode", 49, "Manuel", 1002);
        Asistentes.Add(Asistente3);

        Asistentes.Sort();

        foreach (AsistenteDeCabina c in Asistentes)
        {
            Console.WriteLine(c.ToString());
        }
    }
}