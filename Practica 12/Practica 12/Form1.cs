using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    public partial class Form1 : Form
    {
        private Juego juego;
        private Timer timerEnfilado;
        private Color colorSeleccionado;

        public Form1()
        {
            InitializeComponent();
            juego = new Juego();
            InicializarTimer();
            colorSeleccionado = Color.Empty;
            btnReiniciar.Enabled = false;  // Deshabilita el botón al inicio del juego
        }

        private void InicializarTimer()
        {
            timerEnfilado = new Timer();
            timerEnfilado.Interval = 5000; // 5 segundos
            timerEnfilado.Tick += TimerEnfilado_Tick;
            timerEnfilado.Start();
        }

        private void TimerEnfilado_Tick(object sender, EventArgs e)
        {
            if (juego.Cola.CarrosEnCola() < 5)
            {
                Carro nuevoCarro = juego.GenerarCarroAleatorio();
                juego.Cola.EnfilarCarro(nuevoCarro);
                ActualizarColaVisual();
            }
            else
            {
                TerminarJuego();
            }
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            if (colorSeleccionado == Color.Empty)
            {
                MessageBox.Show("Por favor selecciona un color.");
                return;
            }

            Carro carroEnAtencion = juego.Cola.AtenderCarro();
            if (carroEnAtencion != null && carroEnAtencion.ColorEtiqueta == colorSeleccionado)
            {
                // Si el color es correcto, pintamos el coche
                juego.AtenderCarro(carroEnAtencion);
                ActualizarColaVisual();
                ActualizarPuntuacion(); // Llamamos para actualizar la puntuación
                VerificarVelocidad();
            }
            else
            {
                MessageBox.Show("El color seleccionado no corresponde con el coche en fila.");
            }
        }

        private void ActualizarPuntuacion()
        {
            lblCarrosPintados.Text = $"Carros pintados: {juego.CarrosPintados}";
        }



        private void ActualizarColaVisual()
        {
            var carros = juego.Cola.ObtenerCola();

            // Limpiar los PictureBox antes de asignar las imágenes
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;

            // Limpiar los textos de los labels
            labelColor1.Text = "";
            labelColor2.Text = "";
            labelColor3.Text = "";
            labelColor4.Text = "";
            labelColor5.Text = "";

            // Ruta de la imagen del coche base
            string rutaImagen = @"C:\Users\chanj\Desktop\ADRIAN MOSQUEDA .-\MATERIAS\Estructura de datos\Practica 12\Practica 12\imagenes\coche.png";

            try
            {
                if (carros.Count > 0)
                {
                    pictureBox1.Image = Image.FromFile(rutaImagen);
                    labelColor1.Text = ColorToText(carros[0].ColorEtiqueta);
                }
                if (carros.Count > 1)
                {
                    pictureBox2.Image = Image.FromFile(rutaImagen);
                    labelColor2.Text = ColorToText(carros[1].ColorEtiqueta);
                }
                if (carros.Count > 2)
                {
                    pictureBox3.Image = Image.FromFile(rutaImagen);
                    labelColor3.Text = ColorToText(carros[2].ColorEtiqueta);
                }
                if (carros.Count > 3)
                {
                    pictureBox4.Image = Image.FromFile(rutaImagen);
                    labelColor4.Text = ColorToText(carros[3].ColorEtiqueta);
                }
                if (carros.Count > 4)
                {
                    pictureBox5.Image = Image.FromFile(rutaImagen);
                    labelColor5.Text = ColorToText(carros[4].ColorEtiqueta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private string ColorToText(Color color)
        {
            if (color == Color.Red) return "Rojo";
            if (color == Color.Green) return "Verde";
            if (color == Color.Orange) return "Naranja";
            if (color == Color.Yellow) return "Amarillo";
            return "Desconocido";
        }

        // Método para aplicar el color al coche
        private Image PintarCocheConColor(string rutaImagen, Color color)
        {
            // Cargar la imagen base del coche
            Bitmap coche = new Bitmap(rutaImagen);

            // Crear una nueva imagen con el mismo tamaño
            Bitmap cocheColoreado = new Bitmap(coche.Width, coche.Height);

            // Recorrer todos los píxeles de la imagen y colorear los píxeles del coche
            for (int y = 0; y < coche.Height; y++)
            {
                for (int x = 0; x < coche.Width; x++)
                {
                    Color originalColor = coche.GetPixel(x, y);

                    // Si el pixel no es transparente, aplicar el color seleccionado
                    if (originalColor.A > 0)  // Solo si el píxel no es transparente
                    {
                        cocheColoreado.SetPixel(x, y, color);
                    }
                    else
                    {
                        cocheColoreado.SetPixel(x, y, originalColor);
                    }
                }
            }

            return cocheColoreado;
        }

        private void VerificarVelocidad()
        {
            if (juego.CarrosPintados >= 3)
            {
                timerEnfilado.Interval = 1000; // Aumenta la velocidad después de 3 coches pintados
            }
        }

        private void TerminarJuego()
        {
            timerEnfilado.Stop();  // Detiene el temporizador cuando termina el juego
            MessageBox.Show($"Juego terminado! Carros pintados: {juego.CarrosPintados}. Tiempo total: {juego.ObtenerTiempoTotal()}");

            btnReiniciar.Enabled = true;  // Habilita el botón de reinicio para comenzar de nuevo
        }


        // Método para seleccionar un color de la paleta
        private void btnSeleccionarColor_Click(object sender, EventArgs e)
        {
            Button btnColor = sender as Button;
            colorSeleccionado = btnColor.BackColor; // Usamos el color de fondo del botón para la selección
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Reinicia el juego
            juego = new Juego();  // Crear un nuevo juego
            colorSeleccionado = Color.Empty;  // Limpia la selección de color
            timerEnfilado.Start();  // Vuelve a iniciar el temporizador

            // Limpia la interfaz visual
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;

            labelColor1.Text = "";
            labelColor2.Text = "";
            labelColor3.Text = "";
            labelColor4.Text = "";
            labelColor5.Text = "";

            lblCarrosPintados.Text = "Carros pintados: 0";  // Reinicia el contador de carros pintados
        }

    }
}
