namespace Practica_12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnNaranja = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnPintar = new System.Windows.Forms.Button();
            this.lblCarrosPintados = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.labelColor1 = new System.Windows.Forms.Label();
            this.labelColor2 = new System.Windows.Forms.Label();
            this.labelColor3 = new System.Windows.Forms.Label();
            this.labelColor4 = new System.Windows.Forms.Label();
            this.labelColor5 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(120, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(202, 41);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(285, 41);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(368, 41);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(38, 106);
            this.btnRojo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 41);
            this.btnRojo.TabIndex = 5;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnSeleccionarColor_Click);
            // 
            // btnNaranja
            // 
            this.btnNaranja.BackColor = System.Drawing.Color.Orange;
            this.btnNaranja.Location = new System.Drawing.Point(120, 106);
            this.btnNaranja.Margin = new System.Windows.Forms.Padding(2);
            this.btnNaranja.Name = "btnNaranja";
            this.btnNaranja.Size = new System.Drawing.Size(75, 41);
            this.btnNaranja.TabIndex = 6;
            this.btnNaranja.UseVisualStyleBackColor = false;
            this.btnNaranja.Click += new System.EventHandler(this.btnSeleccionarColor_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Location = new System.Drawing.Point(202, 106);
            this.btnVerde.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(75, 41);
            this.btnVerde.TabIndex = 7;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnSeleccionarColor_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarillo.Location = new System.Drawing.Point(285, 106);
            this.btnAmarillo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(75, 41);
            this.btnAmarillo.TabIndex = 8;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnSeleccionarColor_Click);
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(38, 171);
            this.btnPintar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(112, 32);
            this.btnPintar.TabIndex = 9;
            this.btnPintar.Text = "Pintar Primer Coche";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // lblCarrosPintados
            // 
            this.lblCarrosPintados.AutoSize = true;
            this.lblCarrosPintados.Location = new System.Drawing.Point(38, 219);
            this.lblCarrosPintados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarrosPintados.Name = "lblCarrosPintados";
            this.lblCarrosPintados.Size = new System.Drawing.Size(92, 13);
            this.lblCarrosPintados.TabIndex = 10;
            this.lblCarrosPintados.Text = "Carros pintados: 0";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(38, 16);
            this.lblCola.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(95, 13);
            this.lblCola.TabIndex = 11;
            this.lblCola.Text = "Coches en la cola:";
            // 
            // labelColor1
            // 
            this.labelColor1.AutoSize = true;
            this.labelColor1.Location = new System.Drawing.Point(38, 85);
            this.labelColor1.Name = "labelColor1";
            this.labelColor1.Size = new System.Drawing.Size(35, 13);
            this.labelColor1.TabIndex = 12;
            this.labelColor1.Text = "label1";
            // 
            // labelColor2
            // 
            this.labelColor2.AutoSize = true;
            this.labelColor2.Location = new System.Drawing.Point(120, 85);
            this.labelColor2.Name = "labelColor2";
            this.labelColor2.Size = new System.Drawing.Size(35, 13);
            this.labelColor2.TabIndex = 13;
            this.labelColor2.Text = "label2";
            // 
            // labelColor3
            // 
            this.labelColor3.AutoSize = true;
            this.labelColor3.Location = new System.Drawing.Point(202, 85);
            this.labelColor3.Name = "labelColor3";
            this.labelColor3.Size = new System.Drawing.Size(35, 13);
            this.labelColor3.TabIndex = 14;
            this.labelColor3.Text = "label3";
            // 
            // labelColor4
            // 
            this.labelColor4.AutoSize = true;
            this.labelColor4.Location = new System.Drawing.Point(285, 85);
            this.labelColor4.Name = "labelColor4";
            this.labelColor4.Size = new System.Drawing.Size(35, 13);
            this.labelColor4.TabIndex = 15;
            this.labelColor4.Text = "label4";
            // 
            // labelColor5
            // 
            this.labelColor5.AutoSize = true;
            this.labelColor5.Location = new System.Drawing.Point(368, 85);
            this.labelColor5.Name = "labelColor5";
            this.labelColor5.Size = new System.Drawing.Size(35, 13);
            this.labelColor5.TabIndex = 16;
            this.labelColor5.Text = "label5";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(38, 250);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(112, 32);
            this.btnReiniciar.TabIndex = 17;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 320);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.labelColor5);
            this.Controls.Add(this.labelColor4);
            this.Controls.Add(this.labelColor3);
            this.Controls.Add(this.labelColor2);
            this.Controls.Add(this.labelColor1);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblCarrosPintados);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnNaranja);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Juego Pintar Coches";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnNaranja;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Label lblCarrosPintados;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label labelColor1;
        private System.Windows.Forms.Label labelColor2;
        private System.Windows.Forms.Label labelColor3;
        private System.Windows.Forms.Label labelColor4;
        private System.Windows.Forms.Label labelColor5;
        private System.Windows.Forms.Button btnReiniciar;
    }
}
