namespace SistemaUI
{
    partial class FrmEstadisticasGlobales
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCantEmpates = new System.Windows.Forms.RadioButton();
            this.rbCantSinCartas = new System.Windows.Forms.RadioButton();
            this.rbCartasMasUsadas = new System.Windows.Forms.RadioButton();
            this.rbCantPartidasJug = new System.Windows.Forms.RadioButton();
            this.rbHistorialEntreJug = new System.Windows.Forms.RadioButton();
            this.rbJugMasGanador = new System.Windows.Forms.RadioButton();
            this.dgvEst = new System.Windows.Forms.DataGridView();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbJugador1 = new System.Windows.Forms.ComboBox();
            this.lblJugador1 = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.cmbJugador2 = new System.Windows.Forms.ComboBox();
            this.btnBuscarHistorial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(525, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ESTADISTICAS GLOBALES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCantEmpates);
            this.groupBox1.Controls.Add(this.rbCantSinCartas);
            this.groupBox1.Controls.Add(this.rbCartasMasUsadas);
            this.groupBox1.Controls.Add(this.rbCantPartidasJug);
            this.groupBox1.Controls.Add(this.rbHistorialEntreJug);
            this.groupBox1.Controls.Add(this.rbJugMasGanador);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(0, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listados Disponibles";
            // 
            // rbCantEmpates
            // 
            this.rbCantEmpates.AutoSize = true;
            this.rbCantEmpates.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCantEmpates.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbCantEmpates.Location = new System.Drawing.Point(6, 100);
            this.rbCantEmpates.Name = "rbCantEmpates";
            this.rbCantEmpates.Size = new System.Drawing.Size(214, 21);
            this.rbCantEmpates.TabIndex = 5;
            this.rbCantEmpates.Text = "Cantidad Partidas con Empate";
            this.rbCantEmpates.UseVisualStyleBackColor = true;
            this.rbCantEmpates.CheckedChanged += new System.EventHandler(this.rbCantEmpates_CheckedChanged);
            // 
            // rbCantSinCartas
            // 
            this.rbCantSinCartas.AutoSize = true;
            this.rbCantSinCartas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCantSinCartas.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbCantSinCartas.Location = new System.Drawing.Point(244, 100);
            this.rbCantSinCartas.Name = "rbCantSinCartas";
            this.rbCantSinCartas.Size = new System.Drawing.Size(275, 21);
            this.rbCantSinCartas.TabIndex = 4;
            this.rbCantSinCartas.Text = "Cantidad Partidas Finalizadas sin Cartas";
            this.rbCantSinCartas.UseVisualStyleBackColor = true;
            this.rbCantSinCartas.CheckedChanged += new System.EventHandler(this.rbCantSinCartas_CheckedChanged);
            // 
            // rbCartasMasUsadas
            // 
            this.rbCartasMasUsadas.AutoSize = true;
            this.rbCartasMasUsadas.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCartasMasUsadas.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbCartasMasUsadas.Location = new System.Drawing.Point(244, 60);
            this.rbCartasMasUsadas.Name = "rbCartasMasUsadas";
            this.rbCartasMasUsadas.Size = new System.Drawing.Size(228, 21);
            this.rbCartasMasUsadas.TabIndex = 3;
            this.rbCartasMasUsadas.Text = "Cartas Especiales Mas Utilizadas";
            this.rbCartasMasUsadas.UseVisualStyleBackColor = true;
            this.rbCartasMasUsadas.CheckedChanged += new System.EventHandler(this.rbCartasMasUsadas_CheckedChanged);
            // 
            // rbCantPartidasJug
            // 
            this.rbCantPartidasJug.AutoSize = true;
            this.rbCantPartidasJug.Checked = true;
            this.rbCantPartidasJug.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCantPartidasJug.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbCantPartidasJug.Location = new System.Drawing.Point(244, 22);
            this.rbCantPartidasJug.Name = "rbCantPartidasJug";
            this.rbCantPartidasJug.Size = new System.Drawing.Size(213, 21);
            this.rbCantPartidasJug.TabIndex = 2;
            this.rbCantPartidasJug.TabStop = true;
            this.rbCantPartidasJug.Text = "Cantidad De Partidas Jugadas";
            this.rbCantPartidasJug.UseVisualStyleBackColor = true;
            this.rbCantPartidasJug.CheckedChanged += new System.EventHandler(this.rbCantPartidasJug_CheckedChanged);
            // 
            // rbHistorialEntreJug
            // 
            this.rbHistorialEntreJug.AutoSize = true;
            this.rbHistorialEntreJug.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbHistorialEntreJug.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbHistorialEntreJug.Location = new System.Drawing.Point(6, 60);
            this.rbHistorialEntreJug.Name = "rbHistorialEntreJug";
            this.rbHistorialEntreJug.Size = new System.Drawing.Size(184, 21);
            this.rbHistorialEntreJug.TabIndex = 1;
            this.rbHistorialEntreJug.Text = "Historial Entre Jugadores";
            this.rbHistorialEntreJug.UseVisualStyleBackColor = true;
            this.rbHistorialEntreJug.CheckedChanged += new System.EventHandler(this.rbHistorialEntreJug_CheckedChanged);
            // 
            // rbJugMasGanador
            // 
            this.rbJugMasGanador.AutoSize = true;
            this.rbJugMasGanador.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbJugMasGanador.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbJugMasGanador.Location = new System.Drawing.Point(6, 22);
            this.rbJugMasGanador.Name = "rbJugMasGanador";
            this.rbJugMasGanador.Size = new System.Drawing.Size(190, 21);
            this.rbJugMasGanador.TabIndex = 0;
            this.rbJugMasGanador.Text = "Jugadores Mas Ganadores";
            this.rbJugMasGanador.UseVisualStyleBackColor = true;
            this.rbJugMasGanador.CheckedChanged += new System.EventHandler(this.rbJugMasGanador_CheckedChanged);
            // 
            // dgvEst
            // 
            this.dgvEst.AllowUserToAddRows = false;
            this.dgvEst.AllowUserToDeleteRows = false;
            this.dgvEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEst.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEst.Location = new System.Drawing.Point(0, 167);
            this.dgvEst.Name = "dgvEst";
            this.dgvEst.ReadOnly = true;
            this.dgvEst.RowTemplate.Height = 25;
            this.dgvEst.Size = new System.Drawing.Size(525, 196);
            this.dgvEst.TabIndex = 2;
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadistica.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEstadistica.Location = new System.Drawing.Point(0, 273);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(519, 34);
            this.lblEstadistica.TabIndex = 3;
            this.lblEstadistica.Text = "label1";
            this.lblEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 351);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(525, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cmbJugador1
            // 
            this.cmbJugador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.cmbJugador1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJugador1.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbJugador1.FormattingEnabled = true;
            this.cmbJugador1.Location = new System.Drawing.Point(54, 209);
            this.cmbJugador1.Name = "cmbJugador1";
            this.cmbJugador1.Size = new System.Drawing.Size(121, 23);
            this.cmbJugador1.TabIndex = 5;
            this.cmbJugador1.Tag = "Jugadores";
            this.cmbJugador1.Text = "Jugadores";
            // 
            // lblJugador1
            // 
            this.lblJugador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJugador1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJugador1.Location = new System.Drawing.Point(68, 181);
            this.lblJugador1.Name = "lblJugador1";
            this.lblJugador1.Size = new System.Drawing.Size(96, 25);
            this.lblJugador1.TabIndex = 6;
            this.lblJugador1.Text = "Jugador ";
            this.lblJugador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJugador
            // 
            this.lblJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJugador.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJugador.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblJugador.Location = new System.Drawing.Point(351, 181);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(96, 25);
            this.lblJugador.TabIndex = 8;
            this.lblJugador.Text = "Jugador ";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbJugador2
            // 
            this.cmbJugador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.cmbJugador2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbJugador2.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbJugador2.FormattingEnabled = true;
            this.cmbJugador2.Location = new System.Drawing.Point(336, 209);
            this.cmbJugador2.Name = "cmbJugador2";
            this.cmbJugador2.Size = new System.Drawing.Size(121, 23);
            this.cmbJugador2.TabIndex = 7;
            // 
            // btnBuscarHistorial
            // 
            this.btnBuscarHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarHistorial.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarHistorial.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuscarHistorial.Location = new System.Drawing.Point(177, 241);
            this.btnBuscarHistorial.Name = "btnBuscarHistorial";
            this.btnBuscarHistorial.Size = new System.Drawing.Size(158, 29);
            this.btnBuscarHistorial.TabIndex = 6;
            this.btnBuscarHistorial.Text = "Buscar";
            this.btnBuscarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarHistorial.UseVisualStyleBackColor = true;
            this.btnBuscarHistorial.Click += new System.EventHandler(this.btnBuscarHistorial_Click);
            // 
            // FrmEstadisticasGlobales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(525, 390);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscarHistorial);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.cmbJugador2);
            this.Controls.Add(this.lblJugador1);
            this.Controls.Add(this.cmbJugador1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEstadistica);
            this.Controls.Add(this.dgvEst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmEstadisticasGlobales";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEstadisticasGlobales";
            this.Load += new System.EventHandler(this.FrmEstadisticasGlobales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCantPartidasJug;
        private System.Windows.Forms.RadioButton rbHistorialEntreJug;
        private System.Windows.Forms.RadioButton rbCantSinCartas;
        private System.Windows.Forms.RadioButton rbCartasMasUsadas;
        private System.Windows.Forms.RadioButton rbCantEmpates;
        private System.Windows.Forms.DataGridView dgvEst;
        private System.Windows.Forms.RadioButton rbJugMasGanador;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbJugador1;
        private System.Windows.Forms.Label lblJugador1;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.ComboBox cmbJugador2;
        private System.Windows.Forms.Button btnBuscarHistorial;
    }
}