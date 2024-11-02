namespace Banco
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBoxMovimiento = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarACola = new System.Windows.Forms.Button();
            this.btnAtenderEnVentanilla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // comboBoxMovimiento
            // 
            this.comboBoxMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMovimiento.FormattingEnabled = true;
            this.comboBoxMovimiento.Items.AddRange(new object[] {
            "Pago de servicio",
            "Depósito",
            "Retiro",
            "Compra de tiempo-aire",
            "Consulta de saldo"});
            this.comboBoxMovimiento.Location = new System.Drawing.Point(110, 90);
            this.comboBoxMovimiento.Name = "comboBoxMovimiento";
            this.comboBoxMovimiento.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMovimiento.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAgregarACola
            // 
            this.btnAgregarACola.Location = new System.Drawing.Point(340, 50);
            this.btnAgregarACola.Name = "btnAgregarACola";
            this.btnAgregarACola.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarACola.TabIndex = 3;
            this.btnAgregarACola.Text = "Agregar a la Cola";
            this.btnAgregarACola.UseVisualStyleBackColor = true;
            this.btnAgregarACola.Click += new System.EventHandler(this.btnAgregarACola_Click);
            // 
            // btnAtenderEnVentanilla
            // 
            this.btnAtenderEnVentanilla.Location = new System.Drawing.Point(340, 90);
            this.btnAtenderEnVentanilla.Name = "btnAtenderEnVentanilla";
            this.btnAtenderEnVentanilla.Size = new System.Drawing.Size(120, 23);
            this.btnAtenderEnVentanilla.TabIndex = 4;
            this.btnAtenderEnVentanilla.Text = "Atender en Ventanilla";
            this.btnAtenderEnVentanilla.UseVisualStyleBackColor = true;
            this.btnAtenderEnVentanilla.Click += new System.EventHandler(this.btnAtenderEnVentanilla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(340, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salida del sistema";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre del cliente";
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(12, 90);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(94, 13);
            this.lblMovimiento.TabIndex = 7;
            this.lblMovimiento.Text = "Tipo de Movimiento";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(12, 130);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(73, 13);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "Número Turno";
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(110, 130);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroTurno.TabIndex = 9;
            this.lblNumeroTurno.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 341);
            this.Controls.Add(this.lblNumeroTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblMovimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtenderEnVentanilla);
            this.Controls.Add(this.btnAgregarACola);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxMovimiento);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Ventanilla de Banco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBoxMovimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarACola;
        private System.Windows.Forms.Button btnAtenderEnVentanilla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblNumeroTurno;
    }
}

