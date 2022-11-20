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
            this.lblTitulo.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESULTADO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreGanador
            // 
            this.lblNombreGanador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreGanador.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreGanador.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombreGanador.Location = new System.Drawing.Point(0, 33);
            this.lblNombreGanador.Name = "lblNombreGanador";
            this.lblNombreGanador.Size = new System.Drawing.Size(248, 30);
            this.lblNombreGanador.TabIndex = 1;
            this.lblNombreGanador.Text = "Empate";
            this.lblNombreGanador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCartasGanador
            // 
            this.lblCartasGanador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartasGanador.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartasGanador.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCartasGanador.Location = new System.Drawing.Point(0, 63);
            this.lblCartasGanador.Name = "lblCartasGanador";
            this.lblCartasGanador.Size = new System.Drawing.Size(248, 30);
            this.lblCartasGanador.TabIndex = 2;
            this.lblCartasGanador.Text = "Cartas Restantes: xx";
            this.lblCartasGanador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCartasPerdedor
            // 
            this.lblCartasPerdedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartasPerdedor.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCartasPerdedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCartasPerdedor.Location = new System.Drawing.Point(0, 123);
            this.lblCartasPerdedor.Name = "lblCartasPerdedor";
            this.lblCartasPerdedor.Size = new System.Drawing.Size(248, 26);
            this.lblCartasPerdedor.TabIndex = 4;
            this.lblCartasPerdedor.Text = "Cartas Restantes: xx";
            this.lblCartasPerdedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombrePerdedor
            // 
            this.lblNombrePerdedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombrePerdedor.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombrePerdedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombrePerdedor.Location = new System.Drawing.Point(0, 93);
            this.lblNombrePerdedor.Name = "lblNombrePerdedor";
            this.lblNombrePerdedor.Size = new System.Drawing.Size(248, 30);
            this.lblNombrePerdedor.TabIndex = 3;
            this.lblNombrePerdedor.Text = "Empate";
            this.lblNombrePerdedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadMasCuatro
            // 
            this.lblCantidadMasCuatro.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadMasCuatro.ForeColor = System.Drawing.Color.Gainsboro;
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
            this.lblCantidadManos.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadManos.ForeColor = System.Drawing.Color.Gainsboro;
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
            this.lblCantidadMasDos.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadMasDos.ForeColor = System.Drawing.Color.Gainsboro;
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
            this.lblBloqueoReversa.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBloqueoReversa.ForeColor = System.Drawing.Color.Gainsboro;
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
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJugar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnJugar.Location = new System.Drawing.Point(0, 244);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(254, 31);
            this.btnJugar.TabIndex = 12;
            this.btnJugar.Text = "Volver A Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(254, 31);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmFinPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(248, 308);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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