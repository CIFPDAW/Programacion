using DanielDarias.Dni;
public class Persona
{
    private int _edad;
    private string? _nombre;
    private DNI _dni;

    public int Edad
    {
        get
        {
            return _edad;
        }
    }
    public string Nombre
    {
        get
        {
            return _nombre;
        }
    }

    public string DNI {
        get{
            return _dni.ToString();
        }
    }

    public Persona(int e, long nDni, char IDni)
    {
        _edad = e;
        _dni = new DNI(nDni, IDni);
    }

    public Persona(int e, long nDni, char IDni, string n) : this(e, nDni, IDni)
    {
        _nombre = n;
    }

    // public override bool Equals(object? obj)
    // {
    //     if (obj == null || GetType() != obj.GetType()) return false;
    //     Persona p = (Persona)obj;
    //     return this.Nombre == p.Nombre && this.Edad == p.Edad && this._dni.Equals(p._dni);
    // }

    public override string ToString()
    {
        return $"{Nombre} {Edad} {_dni}";
    }

}