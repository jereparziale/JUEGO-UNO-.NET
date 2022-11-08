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
            lblHistorial.Text = $"Historial {salaSeleccionada.Jugador1.NombreUsuario} vs. {salaSeleccionada.Jugador2.NombreUsuario}";
            int cantJ1;
            int cantJ2;
            int ganadasSinCartas;
            salaSeleccionada.PartidasGanadasPorSala(out cantJ1, out cantJ2,out ganadasSinCartas);
            lblVictoriasJ1.Text = $"J1 Victorias: {cantJ1}";
            lblVictoriasJ2.Text = $"J2 Victorias: {cantJ2}";
            lblGanadasSinCartas.Text += $" {ganadasSinCartas}";
            int cantidasMas4;
            int cantidasMas2;
            int cantidasBloqueoReversa;
            salaSeleccionada.EstadisticasPorCartaPorSala(out cantidasMas4,out cantidasMas2, out cantidasBloqueoReversa);
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
