public class ColaCircularDoblementeLigada
{
    private Nodo cabeza;
    private Nodo cola;

    public ColaCircularDoblementeLigada()
    {
        cabeza = null;
        cola = null;
    }

    public bool EstaVacia()
    {
        return cabeza == null;
    }

    public void IngresarAuto(Auto auto)
    {
        Nodo nuevo = new Nodo(auto);

        if (EstaVacia())
        {
            cabeza = nuevo;
            cola = nuevo;
            cabeza.Siguiente = cabeza;
            cabeza.Anterior = cola;
            cola.Siguiente = cabeza;
            cola.Anterior = cabeza;
        }
        else
        {
            nuevo.Anterior = cola;
            nuevo.Siguiente = cabeza;
            cola.Siguiente = nuevo;
            cabeza.Anterior = nuevo;
            cola = nuevo;
        }
    }

    public Auto SalirAuto()
    {
        if (EstaVacia())
        {
            return null;
        }

        Auto autoRemovido = cabeza.Auto;

        if (cabeza == cola)
        {
            cabeza = null;
            cola = null;
        }
        else
        {
            cabeza = cabeza.Siguiente;
            cabeza.Anterior = cola;
            cola.Siguiente = cabeza;
        }

        return autoRemovido;
    }
}
