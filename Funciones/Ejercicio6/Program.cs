// (6) Implementa las funciones disparar y extraerCoordenada para modularizar nuestro programa de “hundir la flota”.
/* Leyenda:
- Barco = 3
- Barco ya tocado = 2
- Agua = 0*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int alt = 9, lon = 9;
        int[,] tablero = new int[alt, lon];
        bool jugando;

        Console.WriteLine("¡Bienvenido a Hundir la Flota!");

        do
        {
            // Solicitar coordenadas en formato A1, B3, etc.
            Console.WriteLine("Introduce las coordenadas para disparar (Ejemplo: A1, B3):");
            string coordenada = Console.ReadLine()?.ToUpper();

            // Validar y convertir la coordenada
            if (extraerCoordenada(tablero, coordenada, out int fila, out int columna))
            {
                string resultado = disparar(tablero, fila, columna);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Coordenadas fuera de rango o formato incorrecto. Intenta de nuevo.");
            }

            // Preguntar si el jugador desea continuar
            Console.Write("¿Quieres seguir jugando? (s/n): ");
            string respuesta = Console.ReadLine()?.ToLower();
            if (respuesta != "s")
            {
                jugando = false;
                Console.WriteLine("¡Gracias por jugar!");
            }
            else jugando = true;
        } while (jugando);
    }

    static string disparar(int[,] tablero, int fila, int columna)
    {
        if (tablero[fila, columna] == 0)
        {
            return "Agua...";
        }
        else if (tablero[fila, columna] == 3)
        {
            tablero[fila, columna] = 2; // Marcar como tocado
            return "¡Tocado!";
        }
        else if (tablero[fila, columna] == 2)
        {
            return "¡Ya habías disparado aquí!";
        }

        return "Error desconocido.";
    }

    static bool extraerCoordenada(int[,] tablero, string coordenada, out int fila, out int columna)
    {
        fila = -1;
        columna = -1;

        // Verificar el formato de la coordenada
        if (coordenada.Length == 2)
        {
            char columnaLetra = coordenada[0];
            char filaNumero = coordenada[1];

            // Convertir la letra a índice
            if (columnaLetra >= 'A' && columnaLetra <= 'J')
            {
                columna = columnaLetra - 'A';
            }
            else
            {
                return false;
            }

            // Convertir el número de fila a índice
            if (filaNumero >= '1' && filaNumero <= '9')
            {
                fila = filaNumero - '1';
            }
            else
            {
                return false;
            }

            // Verificar si las coordenadas están dentro del rango
            if (fila >= 0 && fila < tablero.GetLength(0) && columna >= 0 && columna < tablero.GetLength(1))
            {
                return true;
            }
        }
        return false;
    }
}
