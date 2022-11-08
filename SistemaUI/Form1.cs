using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCore;
using System.Threading;
using FrmMenuPrincipal;
using AccesoADatos;

namespace SistemaUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

      

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Object aux = lstSalas.SelectedItem;
            if(aux is not null)
            {
                try
                {
                    txtJugador1.Clear();
                    txtBaraja.Clear();
                    ((SalaDeJuego)aux).Jugar(ModificarMensajesPartida, FinalizarPartida);
                }
                catch (Exception ex)
                {
                    MostrarVentanaError(ex.Message, "Error");
                }
            }
            else
            {
                MostrarVentanaError("Por favor cree o seleccione una sala para mostrar", "Error");
            }
        }

        private static void MostrarVentanaError(string mensaje,string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Sistema.GuardarPartidasArchivoSql();
            Application.Exit();
        }

        private void btnListadoJugadores_Click(object sender, EventArgs e)
        {
            FrmListados frmListadoJugadores = new FrmListados();
            DialogResult resultado= frmListadoJugadores.ShowDialog();
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            Sistema.AgregarSala();
            lstSalas.Items.Add(Sistema.ListadoSalas.Last());
        }

        private void lstSalas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Object aux = lstSalas.SelectedItem;
            if (aux is not null)
            {
                lblNombreSala.Text = ((SalaDeJuego)aux).ToString();
                txtJugador1.Clear();
                txtBaraja.Clear();
                if(((SalaDeJuego)aux).ListadoDePartidas.Count>0)
                {
                    txtJugador1.AppendText(((SalaDeJuego)aux).PartidaEnJuego.SbMensajeJuego.ToString());
                    txtBaraja.AppendText(((SalaDeJuego)aux).PartidaEnJuego.SbMensajeCartasEnMesa.ToString());
                }
                lblNombreSala.Text = ((SalaDeJuego)aux).ToString();
            }
        }

        public void ModificarMensajesPartida(string mensajeJuego,string mensajeBaraja)
        {
            txtJugador1.Clear();
            txtBaraja.Clear();
            txtJugador1.AppendText(mensajeJuego);
            txtBaraja.AppendText(mensajeBaraja);
        }
        private void FinalizarPartida(string mensajeJuego,Partida partida)
        {
            txtJugador1.AppendText(mensajeJuego);
            FrmFinPartida frmFinPartida = new FrmFinPartida(partida, (SalaDeJuego)lstSalas.SelectedItem);
            DialogResult dialogResult= frmFinPartida.ShowDialog();
            if (dialogResult == DialogResult.OK)
                VolverAJugar((SalaDeJuego)lstSalas.SelectedItem);
        }

        private void VolverAJugar(SalaDeJuego aux)
        {
            try
            {
                txtJugador1.Clear();
                txtBaraja.Clear();
                ((SalaDeJuego)aux).Jugar(ModificarMensajesPartida, FinalizarPartida);
            }
            catch (Exception ex)
            {
                MostrarVentanaError(ex.Message, "Error");
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticasSala frmEstadisticasSala = new FrmEstadisticasSala((SalaDeJuego)lstSalas.SelectedItem);
            frmEstadisticasSala.ShowDialog();
        }

        private void btnEstatisticasGlobales_Click(object sender, EventArgs e)
        {
            //SQL
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Sistema.GuardarPartidasArchivoSql();
            Application.Exit();
        }
    }
}
