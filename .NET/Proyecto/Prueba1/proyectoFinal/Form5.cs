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
    public partial class anyReserva : Form
    {
        public anyReserva()
        {
            InitializeComponent();
        }

        private void btClienteNuevo_Click(object sender, EventArgs e)
        {
            gbCliente.Visible = true;
            gbReservas.Location = new Point(40, 240);
            lbDniCliRe.Visible = false;
            tbCliRe.Visible = false;
            btClienteNuevo.Enabled = false;
            btClienteExist.Enabled = true;
        }

        private void btClienteExist_Click(object sender, EventArgs e)
        {
            gbCliente.Visible = false;
            gbReservas.Location = new Point(40, 65);
            lbDniCliRe.Visible = true;
            tbCliRe.Visible = true;
            btClienteExist.Enabled = false;
            btClienteNuevo.Enabled = true;
        }

        private void anyCliente_Load(object sender, EventArgs e)
        {
            lbDniCliRe.Visible = false;
            tbCliRe.Visible = false;
        }
    }
}
