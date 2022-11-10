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
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
            nupCantidadManos.Minimum = 5;
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            if(Sistema.Configuracion.DeclararPorPuntos)
            {
                rdbPuntos.Checked = true;
                rdbCantidadCartas.Checked = false;
            }else
            {
                rdbPuntos.Checked = false;
                rdbCantidadCartas.Checked = true;
            }
            nupCantidadManos.Value = Sistema.Configuracion.CantidadDeManos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Sistema.Configuracion.CantidadDeManos = Convert.ToInt32(nupCantidadManos.Value);
            Sistema.Configuracion.DeclararPorPuntos = rdbPuntos.Checked;
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
