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
            nupCantidadManos.Value = Sistema.Configuracion.CantidadDeManos;
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
                rdbPuntos.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Sistema.Configuracion.CantidadDeManos = Convert.ToInt32(nupCantidadManos.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
