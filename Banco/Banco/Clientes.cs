// Cliente.cs
using System;

public class Cliente
{
    public int NumeroTurno { get; set; }
    public string Nombre { get; set; }
    public string TipoMovimiento { get; set; }
    public DateTime HoraLlegada { get; set; }

    public Cliente(int numeroTurno, string nombre, string tipoMovimiento)
    {
        NumeroTurno = numeroTurno;
        Nombre = nombre;
        TipoMovimiento = tipoMovimiento;
        HoraLlegada = DateTime.Now;
    }
}
