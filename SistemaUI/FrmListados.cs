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

namespace FrmMenuPrincipal
{
    public partial class FrmListados : Form
    {
        
        public FrmListados()
        {
            InitializeComponent();
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void FrmListados_Load_1(object sender, EventArgs e)
        {
            dgvListados.DataSource = null;
            dgvListados.DataSource = Sistema.ListadoDeUsuarios;
        }
    }
}
