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
        SalaDeJuego salaActual;
        public FrmFinPartida(SalaDeJuego sala,SalaDeJuego salaEnFoco)
        {
            InitializeComponent();

            if (salaEnFoco is not null)
                if (sala != salaEnFoco)
                    btnJugar.Enabled=false;

            salaActual = sala;
            
        }


        private void FrmFinPartida_Load(object sender, EventArgs e)
        {
            if(salaActual.PartidaEnJuego.JugadorGanador is not null)
            {
                lblNombreGanador.Text = $"Ganador {salaActual.PartidaEnJuego.JugadorGanador.NombreUsuario}";
                lblCartasGanador.Text = $"Cartas Restantes: {salaActual.PartidaEnJuego.JugadorGanador.CartasRestantes}";

                if (salaActual.PartidaEnJuego.JugadorGanador.Equals(salaActual.PartidaEnJuego.Jugador1))
                {
                    lblNombrePerdedor.Text = $"Perdedor {salaActual.PartidaEnJuego.Jugador2.NombreUsuario}";
                    lblCartasPerdedor.Text = $"Cartas Restantes: {salaActual.PartidaEnJuego.Jugador2.CartasRestantes}";

                }
                else
                {
                    lblNombrePerdedor.Text = $"Perdedor {salaActual.PartidaEnJuego.Jugador1.NombreUsuario}";
                    lblCartasPerdedor.Text =$"Cartas Restantes: {salaActual.PartidaEnJuego.Jugador1.CartasRestantes}";
                }
            }
            else
            {
                lblCartasGanador.Text = $"Cartas Restantes: {salaActual.PartidaEnJuego.Jugador1.CartasRestantes}";
                lblCartasPerdedor.Text = $"Cartas Restantes: {salaActual.PartidaEnJuego.Jugador2.CartasRestantes}";
            }
            lblTitulo.Text += $" {salaActual.PartidaEnJuego.Jugador1.NombreUsuario}-{salaActual.PartidaEnJuego.Jugador2.NombreUsuario}";
            lblCantidadMasDos.Text = $"Cantidad +2 usados: {salaActual.PartidaEnJuego.CantidadMasDosUsados}";
            lblCantidadMasCuatro.Text = $"Cantidad +4 usados: {salaActual.PartidaEnJuego.CantidadMasCuatroUsados}";
            lblBloqueoReversa.Text = $"Cantidad reserva y bloqueo usados: {salaActual.PartidaEnJuego.CantidadBloqueoReversa}";
            lblCantidadManos.Text = $"Cantidad manos: {salaActual.PartidaEnJuego.ManosJugadas}";
            

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
