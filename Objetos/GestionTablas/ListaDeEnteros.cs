public class ListaDeEnteros
{
    private int[] datos = new int[10];
    private int nDatos;

    public void Add(int n)
    {
        int[] aux;
        if (nDatos == datos.Length)
        {
            aux = new int[datos.Length + 10];
            for (int i = 0; i < datos.Length; i++)
                aux[i] = datos[i];
            datos = aux;
        }

        datos[nDatos] = n;
        nDatos++;
    }
    public int Length()
    {
        return nDatos;
    }
    public int Get(int pos)
    {
        if (pos >= nDatos)
            throw new Exception();
        return datos[pos];
    }

    public int Delete(int pos)
    {
        if (pos >= nDatos)
            throw new Exception();
        int aux = datos[pos];
        for (int i = pos; i < nDatos - 1; i++)
            datos[i] = datos[i + 1];
        nDatos--;
        return aux;
    }

}