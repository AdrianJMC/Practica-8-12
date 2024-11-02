using System.Collections.Generic;

public class ColaCarros
{
    private Queue<Carro> cola;

    public ColaCarros()
    {
        cola = new Queue<Carro>();
    }

    public void EnfilarCarro(Carro carro)
    {
        cola.Enqueue(carro);
    }

    public Carro AtenderCarro()
    {
        if (cola.Count > 0)
        {
            return cola.Dequeue();
        }
        return null;
    }

    public int CarrosEnCola()
    {
        return cola.Count;
    }

    public List<Carro> ObtenerCola()
    {
        return new List<Carro>(cola);
    }
}
