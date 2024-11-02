using PilaReemplazo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reemplazar_valor
{
    public partial class Form1 : Form
    {
        // Instancia de la clase Pila
        Pila miPila = new Pila();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para mostrar la pila en el ListBox
        private void MostrarPila()
        {
            listBox1.Items.Clear(); // Limpiamos el ListBox
            List<int> elementos = miPila.ObtenerElementos();

            foreach (int item in elementos)
            {
                listBox1.Items.Add(item); // Añadimos cada elemento de la pila al ListBox
            }
        }

        // Evento del botón para agregar un número a la pila
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                miPila.Apilar(numero);
                MostrarPila();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Introduce un número válido");
            }
        }

        // Evento del botón para reemplazar un valor en la pila
        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxViejo.Text, out int viejo) && int.TryParse(textBoxNuevo.Text, out int nuevo))
            {
                miPila.Reemplazar(nuevo, viejo);
                MostrarPila();
            }
            else
            {
                MessageBox.Show("Introduce valores válidos para 'Viejo' y 'Nuevo'");
            }
        }
    }
}
