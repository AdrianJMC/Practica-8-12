using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_13
{
    public partial class Form1 : Form
    {
        private ColaCircularDoblementeLigada estacionamiento = new ColaCircularDoblementeLigada();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntradaAuto_Click(object sender, EventArgs e)
        {
            string placas = txtPlacas.Text;
            string propietario = txtPropietario.Text;

            if (string.IsNullOrWhiteSpace(placas) || string.IsNullOrWhiteSpace(propietario))
            {
                MessageBox.Show("Por favor, ingresa las placas y el propietario.");
                return;
            }

            Auto nuevoAuto = new Auto(placas, propietario);
            estacionamiento.IngresarAuto(nuevoAuto);
            lblInfo.Text = $"Auto {placas} ingresado a las {nuevoAuto.HoraEntrada}.";
        }

        private void btnSalidaAuto_Click(object sender, EventArgs e)
        {
            if (estacionamiento.EstaVacia())
            {
                MessageBox.Show("El estacionamiento está vacío.");
                return;
            }

            Auto auto = estacionamiento.SalirAuto();
            DateTime horaSalida = DateTime.Now;
            TimeSpan tiempoEstacionado = horaSalida - auto.HoraEntrada;

            double costo = tiempoEstacionado.TotalSeconds * 2;
            lblInfo.Text = $"Auto {auto.Placas} retirado. Propietario: {auto.Propietario}\n" +
                           $"Hora de entrada: {auto.HoraEntrada}\n" +
                           $"Hora de salida: {horaSalida}\n" +
                           $"Costo: ${costo:F2} pesos.";
        }
    }
}
