namespace DanielDarias.Dni;

public class DNI
{
    private char _idni;
    private long _ndni;

    public char IDni
    {
        get
        {
            return _idni;
        }
    }

    public long nDni
    {
        get
        {
            return _ndni;
        }
    }

    public DNI()
    {
        _ndni = 0;
        _idni = ' ';
    }
    public DNI(long num, char I):this()
    {
        _ndni = num;
        if (LetraValida(num) == I)
            _idni = I;
        else
            throw new System.ArgumentException("Letra no válida");
    }

    public override bool Equals(object? f)
    {
        if (f == null || GetType() != f.GetType()) return false;
        DNI OtroDNI = (DNI)f;
        return this.IDni == OtroDNI.IDni && this.nDni == OtroDNI.nDni;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(IDni, nDni);
    }


    private char LetraValida(long n)
    {
        char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        return letras[n % 23];
    }

    public override string ToString()
    {
        return $"{nDni}{IDni}";
    }

}