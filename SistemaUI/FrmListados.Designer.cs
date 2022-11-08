namespace FrmMenuPrincipal
{
    partial class FrmListados
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
            this.dgvListados = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListados
            // 
            this.dgvListados.AllowUserToAddRows = false;
            this.dgvListados.AllowUserToOrderColumns = true;
            this.dgvListados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListados.Location = new System.Drawing.Point(12, 79);
            this.dgvListados.Name = "dgvListados";
            this.dgvListados.ReadOnly = true;
            this.dgvListados.RowTemplate.Height = 25;
            this.dgvListados.Size = new System.Drawing.Size(447, 249);
            this.dgvListados.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(3, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(467, 52);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Listado Jugadores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 32);
            this.panel2.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(347, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 42);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // FrmListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(471, 403);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvListados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flota de Aviones";
            this.Load += new System.EventHandler(this.FrmListados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
    }
}