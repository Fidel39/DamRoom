using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class conReservas : Form
    {
        public conReservas()
        {
            InitializeComponent();
        }

        private void enables()
        {
            tbDNICli.Enabled = false;
            tbHabi.Enabled = false;
            tbImporte.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFechaIni.Enabled = false;
        }
        private void btDniCli_Click(object sender, EventArgs e)
        {
            enables();
            tbDNICli.Enabled = true;

        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
