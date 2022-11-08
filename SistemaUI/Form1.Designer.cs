namespace SistemaUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJugador = new System.Windows.Forms.Label();
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.txtBaraja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.btnListadoJugadores = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstatisticasGlobales = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblNombreSala = new System.Windows.Forms.Label();
            this.btnPausarSala = new System.Windows.Forms.Button();
            this.btnCancelarPartida = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.lblSalas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.Location = new System.Drawing.Point(470, 38);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(403, 23);
            this.lblJugador.TabIndex = 7;
            this.lblJugador.Text = "Jugador 1 vs. Jugador 2 UNO";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtJugador1
            // 
            this.txtJugador1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJugador1.Location = new System.Drawing.Point(470, 64);
            this.txtJugador1.Multiline = true;
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.ReadOnly = true;
            this.txtJugador1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJugador1.Size = new System.Drawing.Size(403, 397);
            this.txtJugador1.TabIndex = 11;
            // 
            // txtBaraja
            // 
            this.txtBaraja.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBaraja.Location = new System.Drawing.Point(215, 194);
            this.txtBaraja.Multiline = true;
            this.txtBaraja.Name = "txtBaraja";
            this.txtBaraja.ReadOnly = true;
            this.txtBaraja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBaraja.Size = new System.Drawing.Size(238, 103);
            this.txtBaraja.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(215, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cartas en mesa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSala.Location = new System.Drawing.Point(0, 0);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(213, 35);
            this.btnCrearSala.TabIndex = 0;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = true;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnListadoJugadores
            // 
            this.btnListadoJugadores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListadoJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoJugadores.Location = new System.Drawing.Point(213, 0);
            this.btnListadoJugadores.Name = "btnListadoJugadores";
            this.btnListadoJugadores.Size = new System.Drawing.Size(162, 35);
            this.btnListadoJugadores.TabIndex = 1;
            this.btnListadoJugadores.Text = "Listado Jugadores";
            this.btnListadoJugadores.UseVisualStyleBackColor = true;
            this.btnListadoJugadores.Click += new System.EventHandler(this.btnListadoJugadores_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Location = new System.Drawing.Point(375, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(126, 35);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadisticas De Sala";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Controls.Add(this.btnEstatisticasGlobales);
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Controls.Add(this.btnListadoJugadores);
            this.panel1.Controls.Add(this.btnCrearSala);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 35);
            this.panel1.TabIndex = 19;
            // 
            // btnEstatisticasGlobales
            // 
            this.btnEstatisticasGlobales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstatisticasGlobales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstatisticasGlobales.Location = new System.Drawing.Point(501, 0);
            this.btnEstatisticasGlobales.Name = "btnEstatisticasGlobales";
            this.btnEstatisticasGlobales.Size = new System.Drawing.Size(140, 35);
            this.btnEstatisticasGlobales.TabIndex = 3;
            this.btnEstatisticasGlobales.Text = "Estadisticas Globales";
            this.btnEstatisticasGlobales.UseVisualStyleBackColor = true;
            this.btnEstatisticasGlobales.Click += new System.EventHandler(this.btnEstatisticasGlobales_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(3, 64);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(72, 24);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblNombreSala
            // 
            this.lblNombreSala.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreSala.Location = new System.Drawing.Point(-1, 17);
            this.lblNombreSala.Name = "lblNombreSala";
            this.lblNombreSala.Size = new System.Drawing.Size(237, 18);
            this.lblNombreSala.TabIndex = 0;
            this.lblNombreSala.Text = "Sala 1";
            this.lblNombreSala.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPausarSala
            // 
            this.btnPausarSala.Location = new System.Drawing.Point(90, 64);
            this.btnPausarSala.Name = "btnPausarSala";
            this.btnPausarSala.Size = new System.Drawing.Size(58, 23);
            this.btnPausarSala.TabIndex = 4;
            this.btnPausarSala.Text = "Pausa";
            this.btnPausarSala.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPartida
            // 
            this.btnCancelarPartida.Location = new System.Drawing.Point(165, 64);
            this.btnCancelarPartida.Name = "btnCancelarPartida";
            this.btnCancelarPartida.Size = new System.Drawing.Size(68, 23);
            this.btnCancelarPartida.TabIndex = 5;
            this.btnCancelarPartida.Text = "Cancelar";
            this.btnCancelarPartida.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancelarPartida);
            this.panel3.Controls.Add(this.btnPausarSala);
            this.panel3.Controls.Add(this.lblNombreSala);
            this.panel3.Controls.Add(this.btnJugar);
            this.panel3.Location = new System.Drawing.Point(215, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 101);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstSalas);
            this.panel2.Controls.Add(this.lblSalas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 438);
            this.panel2.TabIndex = 21;
            // 
            // lstSalas
            // 
            this.lstSalas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lstSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstSalas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 17;
            this.lstSalas.Location = new System.Drawing.Point(0, 23);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(213, 425);
            this.lstSalas.TabIndex = 21;
            this.lstSalas.SelectedIndexChanged += new System.EventHandler(this.lstSalas_SelectedIndexChanged_1);
            // 
            // lblSalas
            // 
            this.lblSalas.BackColor = System.Drawing.Color.DarkGray;
            this.lblSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalas.Location = new System.Drawing.Point(0, 0);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(213, 23);
            this.lblSalas.TabIndex = 0;
            this.lblSalas.Text = "SALAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(215, 303);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 158);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Location = new System.Drawing.Point(641, 0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(140, 35);
            this.btnConfiguracion.TabIndex = 4;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(781, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 473);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaraja);
            this.Controls.Add(this.txtJugador1);
            this.Controls.Add(this.lblJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.TextBox txtBaraja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCrearSala;
        private System.Windows.Forms.Button btnListadoJugadores;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblNombreSala;
        private System.Windows.Forms.Button btnPausarSala;
        private System.Windows.Forms.Button btnCancelarPartida;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEstatisticasGlobales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}
