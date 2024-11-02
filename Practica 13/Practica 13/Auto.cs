using System;

public class Auto
{
    public string Placas { get; set; }
    public string Propietario { get; set; }
    public DateTime HoraEntrada { get; set; }

    public Auto(string placas, string propietario)
    {
        Placas = placas;
        Propietario = propietario;
        HoraEntrada = DateTime.Now;
    }
}
