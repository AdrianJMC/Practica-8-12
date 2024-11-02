namespace Reemplazar_valor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBoxViejo = new System.Windows.Forms.TextBox();
            this.textBoxNuevo = new System.Windows.Forms.TextBox();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.labelViejo = new System.Windows.Forms.Label();
            this.labelNuevo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 225);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(174, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar a la Pila";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textBoxViejo
            // 
            this.textBoxViejo.Location = new System.Drawing.Point(174, 90);
            this.textBoxViejo.Name = "textBoxViejo";
            this.textBoxViejo.Size = new System.Drawing.Size(100, 20);
            this.textBoxViejo.TabIndex = 3;
            // 
            // textBoxNuevo
            // 
            this.textBoxNuevo.Location = new System.Drawing.Point(174, 140);
            this.textBoxNuevo.Name = "textBoxNuevo";
            this.textBoxNuevo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNuevo.TabIndex = 4;
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(174, 166);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(100, 23);
            this.btnReemplazar.TabIndex = 5;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            this.btnReemplazar.Click += new System.EventHandler(this.btnReemplazar_Click);
            // 
            // labelViejo
            // 
            this.labelViejo.AutoSize = true;
            this.labelViejo.Location = new System.Drawing.Point(174, 74);
            this.labelViejo.Name = "labelViejo";
            this.labelViejo.Size = new System.Drawing.Size(29, 13);
            this.labelViejo.TabIndex = 6;
            this.labelViejo.Text = "Viejo";
            // 
            // labelNuevo
            // 
            this.labelNuevo.AutoSize = true;
            this.labelNuevo.Location = new System.Drawing.Point(174, 124);
            this.labelNuevo.Name = "labelNuevo";
            this.labelNuevo.Size = new System.Drawing.Size(38, 13);
            this.labelNuevo.TabIndex = 7;
            this.labelNuevo.Text = "Nuevo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelNuevo);
            this.Controls.Add(this.labelViejo);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.textBoxNuevo);
            this.Controls.Add(this.textBoxViejo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Reemplazo en Pila";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBoxViejo;
        private System.Windows.Forms.TextBox textBoxNuevo;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Label labelViejo;
        private System.Windows.Forms.Label labelNuevo;
    }
}

