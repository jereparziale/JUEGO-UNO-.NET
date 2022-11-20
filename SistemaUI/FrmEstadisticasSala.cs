using SistemaCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUI
{
    public partial class FrmEstadisticasSala : Form
    {
        SalaDeJuego salaSeleccionada;
        public FrmEstadisticasSala(SalaDeJuego sala)
        {
            salaSeleccionada = sala;
            InitializeComponent();
        }

        private void FrmEstadisticasSala_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += $"{salaSeleccionada.Descripcion}";
            lblHistorial.Text = $"Historial {salaSeleccionada.Jugador1.NombreUsuario} vs. {salaSeleccionada.Jugador2.NombreUsuario}";
            salaSeleccionada.PartidasGanadasPorSala(out int cantJ1, out int cantJ2,out int ganadasSinCartas);
            lblVictoriasJ1.Text = $"J1 Victorias: {cantJ1}";
            lblVictoriasJ2.Text = $"J2 Victorias: {cantJ2}";
            lblGanadasSinCartas.Text += $" {ganadasSinCartas}";
            salaSeleccionada.EstadisticasPorCartaPorSala(out int cantidasMas4,out int cantidasMas2, out int cantidasBloqueoReversa);
            lblCantidadMasCuatro.Text += $" {cantidasMas4}";
            lblCantidadMasDos.Text += $" {cantidasMas2}";
            lblBloqueoReversa.Text += $" {cantidasBloqueoReversa}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
