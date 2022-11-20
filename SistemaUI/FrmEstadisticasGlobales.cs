using AccesoADatos;
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
    public partial class FrmEstadisticasGlobales : Form
    {
        public FrmEstadisticasGlobales()
        {
            InitializeComponent();
        }

        private void FrmEstadisticasGlobales_Load(object sender, EventArgs e)
        {
            if (rbCantPartidasJug.Checked == true)
            {
                OcultarHerramientasHistorial();
                Sistema.ObtenerEstadisticaCantidadPartidas(ModificarLbl);
            }
        }

        private void OcultarHerramientasHistorial()
        {
            lblJugador.Hide();
            lblJugador1.Hide();
            cmbJugador1.Hide();
            cmbJugador2.Hide();
            btnBuscarHistorial.Hide();
        }
        private void MostrarHerramientasHistorial()
        {
            lblJugador.Show();
            lblJugador1.Show();
            cmbJugador1.Show();
            cmbJugador2.Show();
            btnBuscarHistorial.Show();
        }

        private void rbJugMasGanador_CheckedChanged(object sender, EventArgs e)
        {
            if(rbJugMasGanador.Checked==true)
            {
                lblEstadistica.Hide();
                dgvEst.Rows.Clear();
                dgvEst.Columns.Clear();
                dgvEst.Show();
                dgvEst.Columns.Add("ID Jugador", "ID Jugador");
                dgvEst.Columns.Add("Usuario", "Usuario");
                dgvEst.Columns.Add("Partidas Ganadas", "Partidas Ganadas");
                PartidasDAO.ObtenerEstadisticaJugadorMasGanador(ModificarDgvJugadosMasGanador);
            }
        }

        private void rbCartasMasUsadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCartasMasUsadas.Checked == true)
            {
                lblEstadistica.Hide();
                dgvEst.Rows.Clear();
                dgvEst.Columns.Clear();
                dgvEst.Show();
                dgvEst.Columns.Add("Carta", "Carta");
                dgvEst.Columns.Add("Usos Totales", "Usos Totales");
                PartidasDAO.ObtenerEstadisticaCartaAccionMasUtilizadas(ModificarDgvCartaAccionMasUtilizadas);
            }
        }

        private void ModificarDgvJugadosMasGanador(int idJugador,string nombreUsuario,int partidasGanadas)
        {
           
            dgvEst.Rows.Add(idJugador, nombreUsuario, partidasGanadas);
        }
        private void ModificarDgvCartaAccionMasUtilizadas(string nombreCarta,int cantidadUsos)
        {
           
            dgvEst.Rows.Add(nombreCarta, cantidadUsos);
        }

        private void rbCantPartidasJug_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantPartidasJug.Checked == true)
            {
                OcultarHerramientasHistorial();
                Sistema.ObtenerEstadisticaCantidadPartidas(ModificarLbl);
            }
        }

        private void rbCantEmpates_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantEmpates.Checked == true)
            {
                OcultarHerramientasHistorial();
                Sistema.ObtenerEstadisticaCantidadEmpates(ModificarLbl);
            }
        }

        private void ModificarLbl(string mensaje)
        {
            dgvEst.Hide();
            lblEstadistica.Show();
            lblEstadistica.Text = mensaje;
        }

        private void rbCantSinCartas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCantSinCartas.Checked == true)
            {
                OcultarHerramientasHistorial();
                Sistema.ObtenerEstadisticaCantidadSinCartas(ModificarLbl);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rbHistorialEntreJug_CheckedChanged(object sender, EventArgs e)
        {
            ModificarLbl("Seleccione los jugadores a buscar historial");
            MostrarHerramientasHistorial();
            CargarComboBoxJugadores();
        }

        private void CargarComboBoxJugadores()
        {
            foreach (Usuario item in Sistema.ListadoDeUsuarios)
            {
                cmbJugador1.Items.Add(item);
                cmbJugador2.Items.Add(item);
            }
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            if(cmbJugador1.SelectedItem is not null && cmbJugador2.SelectedItem is not null)
            {
                Usuario J1 = (Usuario)cmbJugador1.SelectedItem;
                Usuario J2 = (Usuario)cmbJugador2.SelectedItem;

                if (J1 != J2)
                {
                    Sistema.ObtenerEstadisticaHistorialJugadores(ModificarLbl, J1.IdJugador, J2.IdJugador);
                }else
                {
                    MostrarVentanaError("Por favor seleccione jugadores distintos", "Error");
                }

            }else
            {
                MostrarVentanaError("Por favor seleccione los jugadores a buscar", "Error");
            }
        }

        private static void MostrarVentanaError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
