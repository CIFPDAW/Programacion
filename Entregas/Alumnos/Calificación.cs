namespace DanielDarias;

public class Calificacion{
    public string Asignatura { get; }
    public float Nota { get; }

    public Calificacion(string _asignatura, float _nota){
        Asignatura = _asignatura;
        Nota = _nota;
    }

    public override string ToString(){
        return $"{Asignatura} {Nota}";
    }
}