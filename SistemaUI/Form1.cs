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
using static SistemaUI.Form1;

namespace SistemaUI
{
    public partial class Form1 : Form
    {
        //Action ModificarUIPartida(string mensajeJugadores,string mensajeBaraja);
        //ModificarUIPartida modificarUIPartida;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //modificarUIPartida = new ModificarUIPartida(ModificarMensajesPartidaTask);
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
                    Task.Run(() => ((SalaDeJuego)aux).Jugar(ModificarMensajesPartidaTask, FinalizarPartida,((SalaDeJuego)aux).CancelToken.Token));
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


        private void btnListadoJugadores_Click(object sender, EventArgs e)
        {
            FrmListados frmListadoJugadores = new FrmListados();
            frmListadoJugadores.ShowDialog();
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            try
            {
                Sistema.AgregarSala();
                lstSalas.Items.Add(Sistema.ListadoSalas.Last());
            }
            
            catch (Exception E)
            {
                MostrarVentanaError(E.Message, "Error");
            }
            
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

        private void btnCancelarPartida_Click(object sender, EventArgs e)
        {
            Object aux = lstSalas.SelectedItem;
            if (aux is not null)
            {
                ((SalaDeJuego)aux).CancelToken.Cancel();
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
        

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frmConfiguracion = new FrmConfiguracion();
            DialogResult dialogResult= frmConfiguracion.ShowDialog();
            if(dialogResult== DialogResult.OK)
            {
                Serializadora<Configuracion>.EscribirJSON(Sistema.Configuracion, "config");
            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Sistema.GuardarPartidasArchivoSql();
            Application.Exit();
        }
        //FIN EVENTOS DEL FORM//////////////////////////////////////////////////////////////////////////////////////////

        private void VolverAJugar(SalaDeJuego aux)
        {
            try
            {
                txtJugador1.Clear();
                txtBaraja.Clear();
                aux.Jugar(ModificarMensajesPartidaTask, FinalizarPartida, aux.CancelToken.Token);
            }
            catch (Exception ex)
            {
                MostrarVentanaError(ex.Message, "Error");
            }
        }

        public void ModificarMensajesPartida(string mensajeJuego, string mensajeBaraja)
        {
            txtJugador1.Clear();
            txtBaraja.Clear();
            txtJugador1.AppendText(mensajeJuego);
            txtBaraja.AppendText(mensajeBaraja);
        }

        private void ModificarMensajesPartidaTask(string mensajeJuego, string mensajeBaraja)
        {
            if (this.txtJugador1.InvokeRequired && this.txtBaraja.InvokeRequired)
            {
                this.txtJugador1.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtJugador1.Clear();
                    txtJugador1.AppendText(mensajeJuego);
                });
                this.txtBaraja.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtBaraja.Clear();
                    txtBaraja.AppendText(mensajeBaraja);
                });
            }
            else
            {
                txtJugador1.Clear();
                txtBaraja.Clear();
                txtJugador1.AppendText(mensajeJuego);
                txtBaraja.AppendText(mensajeBaraja);
            }
        }

        private void FinalizarPartida(string mensajeJuego, Partida partida)
        {
            if (this.txtJugador1.InvokeRequired)
            {
                this.txtJugador1.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtJugador1.AppendText(mensajeJuego);
                    FrmFinPartida frmFinPartida = new FrmFinPartida(partida, (SalaDeJuego)lstSalas.SelectedItem);
                    DialogResult dialogResult = frmFinPartida.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                        VolverAJugar((SalaDeJuego)lstSalas.SelectedItem);
                });
            }
            else
            {
                txtJugador1.AppendText(mensajeJuego);
                FrmFinPartida frmFinPartida = new FrmFinPartida(partida, (SalaDeJuego)lstSalas.SelectedItem);
                DialogResult dialogResult = frmFinPartida.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    VolverAJugar((SalaDeJuego)lstSalas.SelectedItem);
            }
        }


        private static void MostrarVentanaError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        
    }
}
