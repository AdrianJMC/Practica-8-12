namespace Practica_13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEntradaAuto;
        private System.Windows.Forms.Button btnSalidaAuto;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEntradaAuto = new System.Windows.Forms.Button();
            this.btnSalidaAuto = new System.Windows.Forms.Button();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntradaAuto
            // 
            this.btnEntradaAuto.Location = new System.Drawing.Point(20, 120);
            this.btnEntradaAuto.Name = "btnEntradaAuto";
            this.btnEntradaAuto.Size = new System.Drawing.Size(100, 40);
            this.btnEntradaAuto.TabIndex = 0;
            this.btnEntradaAuto.Text = "Entrada de Auto";
            this.btnEntradaAuto.UseVisualStyleBackColor = true;
            this.btnEntradaAuto.Click += new System.EventHandler(this.btnEntradaAuto_Click);
            // 
            // btnSalidaAuto
            // 
            this.btnSalidaAuto.Location = new System.Drawing.Point(140, 120);
            this.btnSalidaAuto.Name = "btnSalidaAuto";
            this.btnSalidaAuto.Size = new System.Drawing.Size(100, 40);
            this.btnSalidaAuto.TabIndex = 1;
            this.btnSalidaAuto.Text = "Salida de Auto";
            this.btnSalidaAuto.UseVisualStyleBackColor = true;
            this.btnSalidaAuto.Click += new System.EventHandler(this.btnSalidaAuto_Click);
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(20, 20);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 2;
            this.lblPlacas.Text = "Placas";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Location = new System.Drawing.Point(20, 60);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(57, 13);
            this.lblPropietario.TabIndex = 3;
            this.lblPropietario.Text = "Propietario";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(100, 20);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(140, 20);
            this.txtPlacas.TabIndex = 4;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(100, 60);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(140, 20);
            this.txtPropietario.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(20, 180);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.btnSalidaAuto);
            this.Controls.Add(this.btnEntradaAuto);
            this.Name = "Form1";
            this.Text = "Estacionamiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

