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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            
        }

      

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Object aux = lstSalas.SelectedItem;
            if(aux is not null)
            {
                try
                {
                    SalaDeJuego salaSeleccionada = (SalaDeJuego)aux;
                    JugarNuevaPartida(salaSeleccionada);
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
                SalaDeJuego sala = ((SalaDeJuego)aux);
                DesuscribirEventos();
                lblNombreSala.Text = sala.ToString();
                txtJugadas.Clear();
                PbCartasEnMesa.Image = null; 
                if(((SalaDeJuego)aux).ListadoDePartidas.Count>0)
                {
                    sala.PartidaEnJuego.EventoModificarUI += ModificarMensajesPartida;
                    //sala.EMostrarPartidaFinalizada += MostrarEstadisticasPartidaFinalizada;
                    sala.ECancelarFinalizarPartida += ModificarMensajesPartida;
                    txtJugadas.AppendText(sala.PartidaEnJuego.SbMensajeJuego.ToString());
                }
            }
        }

        private void DesuscribirEventos()
        {
            foreach (SalaDeJuego item in Sistema.ListadoSalas)
            {
                item.ECancelarFinalizarPartida -= ModificarMensajesPartida;

                if (item.ListadoDePartidas.Count>0)
                item.PartidaEnJuego.EventoModificarUI -= ModificarMensajesPartida;
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
            Object aux = lstSalas.SelectedItem;
            if (aux is not null)
            {
                FrmEstadisticasSala frmEstadisticasSala = new FrmEstadisticasSala((SalaDeJuego)aux);
                frmEstadisticasSala.ShowDialog();
            }
            else
                MostrarVentanaError("No existen salas activas", "Error");
            
            
        }

        private void btnEstatisticasGlobales_Click(object sender, EventArgs e)
        {
            FrmEstadisticasGlobales frmEstadisticasGlobales = new FrmEstadisticasGlobales();
            frmEstadisticasGlobales.ShowDialog();
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
            Sistema.GuardarPartidasEnArchivo();
            Application.Exit();
        }
        //FIN EVENTOS DEL FORM//////////////////////////////////////////////////////////////////////////////////////////

        private void VolverAJugar(SalaDeJuego aux)
        {
            try
            {
                JugarNuevaPartida(aux);
            }
            catch (Exception ex)
            {
                MostrarVentanaError(ex.Message, "Error");
            }
        }


        private void ModificarMensajesPartida(string mensajeJuego,ICarta carta)
         {
            if (this.txtJugadas.InvokeRequired&& this.PbCartasEnMesa.InvokeRequired)
            {
                this.txtJugadas.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtJugadas.Clear();
                    txtJugadas.AppendText(mensajeJuego);
                });
                this.PbCartasEnMesa.BeginInvoke((MethodInvoker)delegate ()
                {
                    if(carta is not null)
                        PbCartasEnMesa.Image = Image.FromFile(carta.PathImagenCarta);
                    else
                        PbCartasEnMesa.Image = Image.FromFile("../../../assets/logo_uno.ico");
                });
            }
            else
            {
                txtJugadas.Clear();
                txtJugadas.AppendText(mensajeJuego);
                PbCartasEnMesa.Image = Image.FromFile(carta.PathImagenCarta);
            }
        } 
        private void MostrarEstadisticasPartidaFinalizada(SalaDeJuego sala)
        {

            if (this.lstSalas.InvokeRequired)
            {
                this.lstSalas.BeginInvoke((MethodInvoker)delegate ()
                {
                    Object aux = lstSalas.SelectedItem;
                    if (aux is not null)
                    {
                        FrmFinPartida frmFinPartida = new FrmFinPartida(sala, (SalaDeJuego)aux);
                        DialogResult dialogResult = frmFinPartida.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                            VolverAJugar(sala);
                    }
                });
            }
            else
            {
                Object aux = lstSalas.SelectedItem;
                if (aux is not null)
                {
                    FrmFinPartida frmFinPartida = new FrmFinPartida(sala, (SalaDeJuego)aux);
                    DialogResult dialogResult = frmFinPartida.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                        VolverAJugar(sala);
                }
            }
            
        }


        private static void MostrarVentanaError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void JugarNuevaPartida(SalaDeJuego salaSeleccionada)
        {
            DesuscribirEventos();
            txtJugadas.Clear();
            PbCartasEnMesa.Image = null;
            Sistema.JugarPartida(salaSeleccionada, MostrarVentanaError);
            //SUSCRIBIR EVENTOS
            if (salaSeleccionada.ListadoDePartidas.Count > 0)
                salaSeleccionada.PartidaEnJuego.EventoModificarUI += ModificarMensajesPartida;

            if(salaSeleccionada.suscribirEventoMostrarEstadistica())
                salaSeleccionada.EMostrarPartidaFinalizada += MostrarEstadisticasPartidaFinalizada;

            salaSeleccionada.ECancelarFinalizarPartida += ModificarMensajesPartida;
        }


    }
}
