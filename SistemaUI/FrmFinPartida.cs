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
    public partial class FrmFinPartida : Form
    {
        Partida partidaAMostrar;
        SalaDeJuego salaActual;
        public FrmFinPartida(Partida partidaFinalizada, SalaDeJuego sala)
        {
            salaActual = sala;
            partidaAMostrar = partidaFinalizada;
            InitializeComponent();
        }


        private void FrmFinPartida_Load(object sender, EventArgs e)
        {
            if(partidaAMostrar.JugadorGanador is not null)
            {
                lblNombreGanador.Text = $"Ganador {partidaAMostrar.JugadorGanador.NombreUsuario}";
                lblCartasGanador.Text = $"Cartas Restantes: {partidaAMostrar.JugadorGanador.CartasRestantes}";

                if (partidaAMostrar.JugadorGanador.Equals(partidaAMostrar.Jugador1))
                {
                    lblNombrePerdedor.Text = $"Perdedor {partidaAMostrar.Jugador2.NombreUsuario}";
                    lblCartasPerdedor.Text = $"Cartas Restantes: {partidaAMostrar.Jugador2.CartasRestantes}";

                }
                else
                {
                    lblNombrePerdedor.Text = $"Perdedor {partidaAMostrar.Jugador1.NombreUsuario}";
                    lblCartasPerdedor.Text =$"Cartas Restantes: {partidaAMostrar.Jugador1.CartasRestantes}";
                }
            }
            else
            {
                lblCartasGanador.Text = $"Cartas Restantes: {partidaAMostrar.Jugador1.CartasRestantes}";
                lblCartasPerdedor.Text = $"Cartas Restantes: {partidaAMostrar.Jugador2.CartasRestantes}";
            }
            lblCantidadMasDos.Text = $"Cantidad +2 usados: {partidaAMostrar.CantidadMasDosUsados}";
            lblCantidadMasCuatro.Text = $"Cantidad +4 usados: {partidaAMostrar.CantidadMasCuatroUsados}";
            lblBloqueoReversa.Text = $"Cantidad reserva y bloqueo usados: {partidaAMostrar.CantidadBloqueoReversa}";
            lblCantidadManos.Text = $"Cantidad manos: {partidaAMostrar.ManosJugadas}";
            

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
