namespace SistemaUI
{
    partial class FrmEstadisticasSala
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
            this.lblBloqueoReversa = new System.Windows.Forms.Label();
            this.lblCantidadMasDos = new System.Windows.Forms.Label();
            this.lblCantidadMasCuatro = new System.Windows.Forms.Label();
            this.lblVictoriasJ2 = new System.Windows.Forms.Label();
            this.lblVictoriasJ1 = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblGanadasSinCartas = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "ESTADISTICA SALA X";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBloqueoReversa
            // 
            this.lblBloqueoReversa.Location = new System.Drawing.Point(0, 156);
            this.lblBloqueoReversa.Name = "lblBloqueoReversa";
            this.lblBloqueoReversa.Size = new System.Drawing.Size(277, 23);
            this.lblBloqueoReversa.TabIndex = 18;
            this.lblBloqueoReversa.Tag = "";
            this.lblBloqueoReversa.Text = "Cantidad Saltos y Reversa:";
            this.lblBloqueoReversa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadMasDos
            // 
            this.lblCantidadMasDos.Location = new System.Drawing.Point(-1, 133);
            this.lblCantidadMasDos.Name = "lblCantidadMasDos";
            this.lblCantidadMasDos.Size = new System.Drawing.Size(277, 23);
            this.lblCantidadMasDos.TabIndex = 16;
            this.lblCantidadMasDos.Tag = "";
            this.lblCantidadMasDos.Text = "Cantidad de +2:";
            this.lblCantidadMasDos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadMasCuatro
            // 
            this.lblCantidadMasCuatro.Location = new System.Drawing.Point(-1, 110);
            this.lblCantidadMasCuatro.Name = "lblCantidadMasCuatro";
            this.lblCantidadMasCuatro.Size = new System.Drawing.Size(277, 23);
            this.lblCantidadMasCuatro.TabIndex = 15;
            this.lblCantidadMasCuatro.Tag = "";
            this.lblCantidadMasCuatro.Text = "Cantidad de +4:";
            this.lblCantidadMasCuatro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVictoriasJ2
            // 
            this.lblVictoriasJ2.Location = new System.Drawing.Point(138, 59);
            this.lblVictoriasJ2.Name = "lblVictoriasJ2";
            this.lblVictoriasJ2.Size = new System.Drawing.Size(138, 23);
            this.lblVictoriasJ2.TabIndex = 14;
            this.lblVictoriasJ2.Text = "J2 X victorias";
            this.lblVictoriasJ2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVictoriasJ1
            // 
            this.lblVictoriasJ1.Location = new System.Drawing.Point(0, 59);
            this.lblVictoriasJ1.Name = "lblVictoriasJ1";
            this.lblVictoriasJ1.Size = new System.Drawing.Size(133, 23);
            this.lblVictoriasJ1.TabIndex = 13;
            this.lblVictoriasJ1.Text = "J1 X victorias";
            this.lblVictoriasJ1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHistorial
            // 
            this.lblHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHistorial.Location = new System.Drawing.Point(0, 33);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(276, 26);
            this.lblHistorial.TabIndex = 12;
            this.lblHistorial.Text = "Historial de sala J1 vs J2 ";
            this.lblHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGanadasSinCartas
            // 
            this.lblGanadasSinCartas.Location = new System.Drawing.Point(-1, 87);
            this.lblGanadasSinCartas.Name = "lblGanadasSinCartas";
            this.lblGanadasSinCartas.Size = new System.Drawing.Size(277, 23);
            this.lblGanadasSinCartas.TabIndex = 19;
            this.lblGanadasSinCartas.Tag = "";
            this.lblGanadasSinCartas.Text = "Partidas Ganadas Sin Cartas:";
            this.lblGanadasSinCartas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(-1, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(278, 31);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmEstadisticasSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 213);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblGanadasSinCartas);
            this.Controls.Add(this.lblBloqueoReversa);
            this.Controls.Add(this.lblCantidadMasDos);
            this.Controls.Add(this.lblCantidadMasCuatro);
            this.Controls.Add(this.lblVictoriasJ2);
            this.Controls.Add(this.lblVictoriasJ1);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmEstadisticasSala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstadisticasSala";
            this.Load += new System.EventHandler(this.FrmEstadisticasSala_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBloqueoReversa;
        private System.Windows.Forms.Label lblCantidadMasDos;
        private System.Windows.Forms.Label lblCantidadMasCuatro;
        private System.Windows.Forms.Label lblVictoriasJ2;
        private System.Windows.Forms.Label lblVictoriasJ1;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblGanadasSinCartas;
        private System.Windows.Forms.Button btnSalir;
    }
}