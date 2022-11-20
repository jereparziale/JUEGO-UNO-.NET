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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.btnListadoJugadores = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnEstatisticasGlobales = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblNombreSala = new System.Windows.Forms.Label();
            this.btnCancelarPartida = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSalas = new System.Windows.Forms.Label();
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.PbCartasEnMesa = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.txtJugadas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbCartasEnMesa)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Carta en mesa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnCrearSala.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSala.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearSala.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCrearSala.Location = new System.Drawing.Point(0, 0);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(213, 35);
            this.btnCrearSala.TabIndex = 0;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = false;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnListadoJugadores
            // 
            this.btnListadoJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnListadoJugadores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListadoJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoJugadores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListadoJugadores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListadoJugadores.Location = new System.Drawing.Point(213, 0);
            this.btnListadoJugadores.Name = "btnListadoJugadores";
            this.btnListadoJugadores.Size = new System.Drawing.Size(156, 35);
            this.btnListadoJugadores.TabIndex = 1;
            this.btnListadoJugadores.Text = "Listado Jugadores";
            this.btnListadoJugadores.UseVisualStyleBackColor = false;
            this.btnListadoJugadores.Click += new System.EventHandler(this.btnListadoJugadores_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstadisticas.Location = new System.Drawing.Point(369, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(168, 35);
            this.btnEstadisticas.TabIndex = 2;
            this.btnEstadisticas.Text = "Estadisticas De Sala";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
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
            this.panel1.Size = new System.Drawing.Size(910, 35);
            this.panel1.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(841, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnConfiguracion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguracion.Location = new System.Drawing.Point(728, 0);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(113, 35);
            this.btnConfiguracion.TabIndex = 4;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnEstatisticasGlobales
            // 
            this.btnEstatisticasGlobales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.btnEstatisticasGlobales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEstatisticasGlobales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstatisticasGlobales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstatisticasGlobales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstatisticasGlobales.Location = new System.Drawing.Point(537, 0);
            this.btnEstatisticasGlobales.Name = "btnEstatisticasGlobales";
            this.btnEstatisticasGlobales.Size = new System.Drawing.Size(191, 35);
            this.btnEstatisticasGlobales.TabIndex = 3;
            this.btnEstatisticasGlobales.Text = "Estadisticas Globales";
            this.btnEstatisticasGlobales.UseVisualStyleBackColor = false;
            this.btnEstatisticasGlobales.Click += new System.EventHandler(this.btnEstatisticasGlobales_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.btnJugar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJugar.Location = new System.Drawing.Point(3, 64);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(111, 34);
            this.btnJugar.TabIndex = 3;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblNombreSala
            // 
            this.lblNombreSala.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreSala.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreSala.Location = new System.Drawing.Point(-1, 15);
            this.lblNombreSala.Name = "lblNombreSala";
            this.lblNombreSala.Size = new System.Drawing.Size(237, 27);
            this.lblNombreSala.TabIndex = 0;
            this.lblNombreSala.Text = "Sala 1";
            this.lblNombreSala.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelarPartida
            // 
            this.btnCancelarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(17)))), ((int)(((byte)(8)))));
            this.btnCancelarPartida.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarPartida.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelarPartida.Location = new System.Drawing.Point(120, 64);
            this.btnCancelarPartida.Name = "btnCancelarPartida";
            this.btnCancelarPartida.Size = new System.Drawing.Size(113, 34);
            this.btnCancelarPartida.TabIndex = 5;
            this.btnCancelarPartida.Text = "Cancelar";
            this.btnCancelarPartida.UseVisualStyleBackColor = false;
            this.btnCancelarPartida.Click += new System.EventHandler(this.btnCancelarPartida_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnCancelarPartida);
            this.panel3.Controls.Add(this.lblNombreSala);
            this.panel3.Controls.Add(this.btnJugar);
            this.panel3.Location = new System.Drawing.Point(31, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 101);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.lblSalas);
            this.panel2.Controls.Add(this.lstSalas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 444);
            this.panel2.TabIndex = 21;
            // 
            // lblSalas
            // 
            this.lblSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.lblSalas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalas.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSalas.Location = new System.Drawing.Point(0, 0);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(213, 27);
            this.lblSalas.TabIndex = 0;
            this.lblSalas.Text = "SALAS";
            // 
            // lstSalas
            // 
            this.lstSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.lstSalas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSalas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstSalas.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstSalas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 17;
            this.lstSalas.Location = new System.Drawing.Point(0, 36);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(213, 408);
            this.lstSalas.TabIndex = 21;
            this.lstSalas.Tag = "Listado";
            this.lstSalas.SelectedIndexChanged += new System.EventHandler(this.lstSalas_SelectedIndexChanged_1);
            // 
            // PbCartasEnMesa
            // 
            this.PbCartasEnMesa.BackColor = System.Drawing.Color.Transparent;
            this.PbCartasEnMesa.Location = new System.Drawing.Point(47, 165);
            this.PbCartasEnMesa.Name = "PbCartasEnMesa";
            this.PbCartasEnMesa.Size = new System.Drawing.Size(188, 267);
            this.PbCartasEnMesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbCartasEnMesa.TabIndex = 22;
            this.PbCartasEnMesa.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::SistemaUI.Properties.Resources.fondoUno;
            this.panelPrincipal.Controls.Add(this.txtJugadas);
            this.panelPrincipal.Controls.Add(this.PbCartasEnMesa);
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(213, 35);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(697, 444);
            this.panelPrincipal.TabIndex = 22;
            // 
            // txtJugadas
            // 
            this.txtJugadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(56)))), ((int)(((byte)(3)))));
            this.txtJugadas.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJugadas.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtJugadas.Location = new System.Drawing.Point(338, 23);
            this.txtJugadas.Multiline = true;
            this.txtJugadas.Name = "txtJugadas";
            this.txtJugadas.ReadOnly = true;
            this.txtJugadas.Size = new System.Drawing.Size(347, 189);
            this.txtJugadas.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(910, 479);
            this.ControlBox = false;
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UNO!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbCartasEnMesa)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCrearSala;
        private System.Windows.Forms.Button btnListadoJugadores;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblNombreSala;
        private System.Windows.Forms.Button btnCancelarPartida;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.PictureBox PbCartasEnMesa;
        private System.Windows.Forms.Button btnEstatisticasGlobales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.TextBox txtJugadas;
    }
}
