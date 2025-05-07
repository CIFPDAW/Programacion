using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        lectordeficheros("op.num");
    }

    private static void lectordeficheros(string fichero)
    {
        string? linea;
        string[] separado;
        decimal num = 0;
        List<string> movimientos = new List<string>();


        if (!File.Exists(fichero))
            throw new ArgumentException($"El fichero \"{fichero}\" no se ha encontrado.");
        else
        {
            try
            {
                using (StreamReader sr = File.OpenText(fichero))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {
                        try
                        {
                            separado = linea.Split(' ');
                            // Logs($"Linea: {linea}");
                            // Logs($"Acto: {separado[0]} - Número: {Convert.ToDecimal(separado[1])}");
                            if (Minuscula(separado[0]) == "acumula" && separado[1] != null)
                            {
                                Logs("[FUNC] LLegando a sumar");
                                num += Convert.ToDecimal(separado[1]);
                                string temp = $"Acción: Acumula - Valor: {Convert.ToDecimal(separado[1])} - Resultado Parcial: {num}";
                                movimientos.Add(temp);
                            }
                            else if (Minuscula(separado[0]) == "divide" && separado[1] != null)
                            {
                                Logs("[FUNC] Llegando a dividir");
                                num = num / Convert.ToDecimal(separado[1]);
                                string temp = $"Acción: Divide - Valor: {Convert.ToDecimal(separado[1])} - Resultado Parcial: {num}";
                                movimientos.Add(temp);
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                        catch (FormatException)
                        {
                        }
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("\n\t\t ----> ERROR: {0}\n", e.Message);
            }

            Console.WriteLine("Resultado: " + num);
            foreach (string c in movimientos)
            {
                Console.WriteLine(c);
            }
        }
    }

    private static void Logs(string Args)
    {
        bool debug = false;

        if (debug)
        {
            Console.WriteLine($"[LOGS] {Args}");
        }
    }

    private static string Minuscula(string Palabra)
    {
        string Temp = "";
        foreach (Char c in Palabra)
        {
            Temp += Char.ToLower(c);
        }
        return Temp;
    }
}