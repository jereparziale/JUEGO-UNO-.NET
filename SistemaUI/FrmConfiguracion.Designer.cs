namespace SistemaUI
{
    partial class FrmConfiguracion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPuntos = new System.Windows.Forms.RadioButton();
            this.rdbCantidadCartas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nupCantidadManos = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadManos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CONFIGURACION";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de manos a Jugar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPuntos);
            this.groupBox1.Controls.Add(this.rdbCantidadCartas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de Juego";
            // 
            // rdbPuntos
            // 
            this.rdbPuntos.AutoSize = true;
            this.rdbPuntos.Location = new System.Drawing.Point(9, 124);
            this.rdbPuntos.Name = "rdbPuntos";
            this.rdbPuntos.Size = new System.Drawing.Size(83, 19);
            this.rdbPuntos.TabIndex = 2;
            this.rdbPuntos.TabStop = true;
            this.rdbPuntos.Text = "Por Puntos";
            this.rdbPuntos.UseVisualStyleBackColor = true;
            // 
            // rdbCantidadCartas
            // 
            this.rdbCantidadCartas.AutoSize = true;
            this.rdbCantidadCartas.Location = new System.Drawing.Point(9, 87);
            this.rdbCantidadCartas.Name = "rdbCantidadCartas";
            this.rdbCantidadCartas.Size = new System.Drawing.Size(180, 19);
            this.rdbCantidadCartas.TabIndex = 1;
            this.rdbCantidadCartas.TabStop = true;
            this.rdbCantidadCartas.Text = "Por Menor cantidad de cartas";
            this.rdbCantidadCartas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccionar el metodo para  declarar ganador cuando ningun jugador se queda sin c" +
    "artas.";
            // 
            // nupCantidadManos
            // 
            this.nupCantidadManos.Location = new System.Drawing.Point(172, 216);
            this.nupCantidadManos.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nupCantidadManos.Name = "nupCantidadManos";
            this.nupCantidadManos.Size = new System.Drawing.Size(40, 23);
            this.nupCantidadManos.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(0, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(223, 36);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(0, 301);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(223, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir Sin Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nupCantidadManos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmConfiguracion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmConfiguracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadManos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPuntos;
        private System.Windows.Forms.RadioButton rdbCantidadCartas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupCantidadManos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}