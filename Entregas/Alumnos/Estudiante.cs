namespace DanielDarias;

public class Estudiante : Persona, IComparable<Estudiante>
{
    private List<Calificacion> calificaciones = new List<Calificacion>();

    private void OrdenarCalificaciones()
    {
        for (int i = 0; i < calificaciones.Count - 1; i++)
        {
            for (int j = 0; j < calificaciones.Count - i - 1; j++)
            {
                if (calificaciones[j].Nota < calificaciones[j + 1].Nota)
                {
                    var temp = calificaciones[j];
                    calificaciones[j] = calificaciones[j + 1];
                    calificaciones[j + 1] = temp;
                }
            }
        }
    }

    public void Calificar(string asignatura, float nota)
    {
        calificaciones.Add(new Calificacion(asignatura, nota));
        OrdenarCalificaciones();
    }

    public int CompareTo(Estudiante? other)
    {
        if (other == null) return 1;
        return this.NotaMedia().CompareTo(other.NotaMedia());
    }

    public Estudiante(int e, long nDni, char IDni) : base(e, nDni, IDni)
    {
    }

    public Estudiante(string n, int e, long nDni, char IDni) : base(e, nDni, IDni, n)
    {
    }

    public float NotaMedia()
    {
        float media = 0;
        foreach (Calificacion c in calificaciones)
        {
            media += c.Nota;
        }
        return media / calificaciones.Count;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {NotaMedia().ToString("F2")}";
    }
}