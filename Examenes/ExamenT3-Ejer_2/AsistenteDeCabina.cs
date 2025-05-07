using facilitado;
namespace herencia;

public class AsistenteDeCabina : Persona, Disponible, IComparable<AsistenteDeCabina>
{
    private static int _HorasTotalesVuelo = 0;
    public int HorasTotalesVuelo
    {
        get
        {
            return _HorasTotalesVuelo;
        }
    }
    private int _HorasVuelo;
    public int HorasVuelo
    {
        get
        {
            return _HorasVuelo;
        }
    }

    public int EdadAsistente
    {
        get
        {
            return getEdad();
        }
    }

    public string NombreAsistente
    {
        get
        {
            return getNombre();
        }
    }

    public AsistenteDeCabina(string n, int e, string a, int Horas) : base(n, a, e)
    {
        _HorasVuelo = +Horas;
        _HorasTotalesVuelo = _HorasTotalesVuelo + Horas;
    }

    public int CompareTo(AsistenteDeCabina? other)
    {
        if (other == null) return 1;
        return this.HorasVuelo.CompareTo(other.HorasVuelo);
    }

    public bool haceVuelosTransatlanticos()
    {
        if (EdadAsistente > 25 && EdadAsistente < 50 && HorasVuelo > 1000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Nombre: {NombreAsistente} \nEdad: {EdadAsistente} \nHoras de Vuelo: {HorasVuelo} - Vuelos Transatlanticos {haceVuelosTransatlanticos()}\nHoras totales de Vuelo: {HorasTotalesVuelo}";
    }
}