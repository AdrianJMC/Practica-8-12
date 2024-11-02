using System.Drawing;

public class Carro
{
    public Color ColorEtiqueta { get; set; }
    public bool Atendido { get; set; }

    public Carro(Color color)
    {
        ColorEtiqueta = color;
        Atendido = false;
    }

    public void Pintar()
    {
        Atendido = true;
    }
}
