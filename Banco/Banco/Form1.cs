using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private ColaBanco colaBanco;
        private int numeroTurno = 1;

        public Form1()
        {
            InitializeComponent();
            colaBanco = new ColaBanco();

            // Agregar las columnas al DataGridView
            InicializarColumnasDataGridView();
        }

        private void InicializarColumnasDataGridView()
        {
            dataGridView1.Columns.Add("NoTurno", "No. Turno");
            dataGridView1.Columns.Add("Nombre", "Nombre del Cliente");
            dataGridView1.Columns.Add("TipoMovimiento", "Tipo de Movimiento");
            dataGridView1.Columns.Add("HoraLlegada", "Hora de Llegada");
        }

        private void btnAgregarACola_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string tipoMovimiento = comboBoxMovimiento.SelectedItem.ToString();

            Cliente cliente = new Cliente(numeroTurno++, nombre, tipoMovimiento);
            colaBanco.AgregarCliente(cliente, dataGridView1);
        }

        private void btnAtenderEnVentanilla_Click(object sender, EventArgs e)
        {
            colaBanco.AtenderCliente(dataGridView1);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
