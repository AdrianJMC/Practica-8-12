// ColaBanco.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ColaBanco
{
    private Queue<Cliente> colaClientes = new Queue<Cliente>();

    public bool ColaLlena(int limiteMaximo)
    {
        return colaClientes.Count >= limiteMaximo;
    }

    public bool ColaVacia()
    {
        return colaClientes.Count == 0;
    }

    public void AgregarCliente(Cliente cliente, DataGridView dataGridView1)
    {
        colaClientes.Enqueue(cliente);
        ActualizarDataGridView(dataGridView1);
        MessageBox.Show($"Cliente formado en la cola:\nNo. Turno: {cliente.NumeroTurno}\nNombre: {cliente.Nombre}\nTipo de Movimiento: {cliente.TipoMovimiento}\nHora de llegada: {cliente.HoraLlegada}");
    }

    public void AtenderCliente(DataGridView dataGridView1)
    {
        if (!ColaVacia())
        {
            Cliente clienteAtendido = colaClientes.Dequeue();
            DateTime horaAtencion = DateTime.Now;
            TimeSpan tiempoEspera = horaAtencion - clienteAtendido.HoraLlegada;
            MessageBox.Show($"Cliente atendido: {clienteAtendido.Nombre}\nTiempo de espera en la cola: {tiempoEspera.Seconds} segundos.");
            ActualizarDataGridView(dataGridView1);
        }
        else
        {
            MessageBox.Show("No hay clientes en la cola.");
        }
    }

    public void ActualizarDataGridView(DataGridView dataGridView1)
    {
        dataGridView1.Rows.Clear();
        foreach (Cliente cliente in colaClientes)
        {
            dataGridView1.Rows.Add(cliente.NumeroTurno, cliente.Nombre, cliente.TipoMovimiento, cliente.HoraLlegada);
        }
    }
}
