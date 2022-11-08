namespace SistemaUI
{
    partial class FrmFinPartida
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
            this.lblNombreGanador = new System.Windows.Forms.Label();
            this.lblCartasGanador = new System.Windows.Forms.Label();
            this.lblCartasPerdedor = new System.Windows.Forms.Label();
            this.lblNombrePerdedor = new System.Windows.Forms.Label();
            this.lblCantidadMasCuatro = new System.Windows.Forms.Label();
            this.lblCantidadManos = new System.Windows.Forms.Label();
            this.lblCantidadMasDos = new System.Windows.Forms.Label();
            this.lblBloqueoReversa = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "FIN DE PARTIDA EN SALA X";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreGanador
            // 
            this.lblNombreGanador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreGanador.Location = new System.Drawing.Point(0, 33);
            this.lblNombreGanador.Name = "lblNombreGanador";
            this.lblNombreGanador.Size = new System.Drawing.Size(270, 30);
            this.lblNombreGanador.TabIndex = 1;
            this.lblNombreGanador.Text = "Empate";
            this.lblNombreGanador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCartasGanador
            // 
            this.lblCartasGanador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartasGanador.Location = new System.Drawing.Point(0, 63);
            this.lblCartasGanador.Name = "lblCartasGanador";
            this.lblCartasGanador.Size = new System.Drawing.Size(270, 30);
            this.lblCartasGanador.TabIndex = 2;
            this.lblCartasGanador.Text = "Cartas Restantes: xx";
            this.lblCartasGanador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCartasPerdedor
            // 
            this.lblCartasPerdedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartasPerdedor.Location = new System.Drawing.Point(0, 123);
            this.lblCartasPerdedor.Name = "lblCartasPerdedor";
            this.lblCartasPerdedor.Size = new System.Drawing.Size(270, 26);
            this.lblCartasPerdedor.TabIndex = 4;
            this.lblCartasPerdedor.Text = "Cartas Restantes: xx";
            this.lblCartasPerdedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombrePerdedor
            // 
            this.lblNombrePerdedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombrePerdedor.Location = new System.Drawing.Point(0, 93);
            this.lblNombrePerdedor.Name = "lblNombrePerdedor";
            this.lblNombrePerdedor.Size = new System.Drawing.Size(270, 30);
            this.lblNombrePerdedor.TabIndex = 3;
            this.lblNombrePerdedor.Text = "Empate";
            this.lblNombrePerdedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadMasCuatro
            // 
            this.lblCantidadMasCuatro.Location = new System.Drawing.Point(0, 149);
            this.lblCantidadMasCuatro.Name = "lblCantidadMasCuatro";
            this.lblCantidadMasCuatro.Size = new System.Drawing.Size(277, 23);
            this.lblCantidadMasCuatro.TabIndex = 8;
            this.lblCantidadMasCuatro.Tag = "";
            this.lblCantidadMasCuatro.Text = "Cantidad de +4:";
            this.lblCantidadMasCuatro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadManos
            // 
            this.lblCantidadManos.Location = new System.Drawing.Point(0, 218);
            this.lblCantidadManos.Name = "lblCantidadManos";
            this.lblCantidadManos.Size = new System.Drawing.Size(277, 23);
            this.lblCantidadManos.TabIndex = 10;
            this.lblCantidadManos.Tag = "";
            this.lblCantidadManos.Text = "Manos Jugadas:";
            this.lblCantidadManos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadMasDos
            // 
            this.lblCantidadMasDos.Location = new System.Drawing.Point(0, 172);
            this.lblCantidadMasDos.Name = "lblCantidadMasDos";
            this.lblCantidadMasDos.Size = new System.Drawing.Size(277, 23);
            this.lblCantidadMasDos.TabIndex = 9;
            this.lblCantidadMasDos.Tag = "";
            this.lblCantidadMasDos.Text = "Cantidad de +2:";
            this.lblCantidadMasDos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBloqueoReversa
            // 
            this.lblBloqueoReversa.Location = new System.Drawing.Point(0, 195);
            this.lblBloqueoReversa.Name = "lblBloqueoReversa";
            this.lblBloqueoReversa.Size = new System.Drawing.Size(277, 23);
            this.lblBloqueoReversa.TabIndex = 11;
            this.lblBloqueoReversa.Tag = "";
            this.lblBloqueoReversa.Text = "Cantidad Saltos y Reversa:";
            this.lblBloqueoReversa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(0, 244);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(273, 31);
            this.btnJugar.TabIndex = 12;
            this.btnJugar.Text = "Volver A Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(0, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(273, 31);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmFinPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 309);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblBloqueoReversa);
            this.Controls.Add(this.lblCantidadManos);
            this.Controls.Add(this.lblCantidadMasDos);
            this.Controls.Add(this.lblCantidadMasCuatro);
            this.Controls.Add(this.lblCartasPerdedor);
            this.Controls.Add(this.lblNombrePerdedor);
            this.Controls.Add(this.lblCartasGanador);
            this.Controls.Add(this.lblNombreGanador);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmFinPartida";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmFinPartida";
            this.Load += new System.EventHandler(this.FrmFinPartida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreGanador;
        private System.Windows.Forms.Label lblCartasGanador;
        private System.Windows.Forms.Label lblCartasPerdedor;
        private System.Windows.Forms.Label lblNombrePerdedor;
        private System.Windows.Forms.Label lblCantidadMasCuatro;
        private System.Windows.Forms.Label lblCantidadManos;
        private System.Windows.Forms.Label lblCantidadMasDos;
        private System.Windows.Forms.Label lblBloqueoReversa;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnSalir;
    }
}