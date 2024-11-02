using System;
using System.Drawing;

public class Juego
{
    public ColaCarros Cola { get; private set; }
    public int CarrosPintados { get; private set; }
    public DateTime InicioJuego { get; private set; }

    public Juego()
    {
        Cola = new ColaCarros();
        CarrosPintados = 0;
        InicioJuego = DateTime.Now;
    }

    public Carro GenerarCarroAleatorio()
    {
        // Colores que queremos utilizar
        Color[] colores = { Color.Red, Color.Green, Color.Orange, Color.Yellow };
        Random rnd = new Random();
        Color colorAleatorio = colores[rnd.Next(colores.Length)];
        return new Carro(colorAleatorio);
    }


    public void AtenderCarro(Carro carro)
    {
        if (carro != null)
        {
            carro.Pintar();
            CarrosPintados++; // Aumenta el contador de carros pintados
        }
    }

    public TimeSpan ObtenerTiempoTotal()
    {
        return DateTime.Now - InicioJuego;
    }
}
