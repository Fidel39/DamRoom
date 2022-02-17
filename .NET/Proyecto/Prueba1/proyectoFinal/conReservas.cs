using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDniCli_Click(object sender, EventArgs e)
        {
            enable();
            tbDNICli.Enabled = true;
        }

        private void conReservas_Load(object sender, EventArgs e)
        {
            enable();
        }

        private void enable()
        {
            tbDNICli.Enabled = false;
            tbHabi.Enabled = false;
            tbImporte.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFechaIni.Enabled = false;
        }

        private void btHabi_Click(object sender, EventArgs e)
        {
            enable();
            tbHabi.Enabled = true;
        }

        private void btFechaIni_Click(object sender, EventArgs e)
        {
            enable();
            dtFechaIni.Enabled = true;
        }

        private void btFechaFin_Click(object sender, EventArgs e)
        {
            enable();
            dtFechaFin.Enabled = true;
        }

        private void btImporte_Click(object sender, EventArgs e)
        {
            enable();
            tbImporte.Enabled = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if(tbDNICli.Enabled)
            {
                String dni = tbDNICli.Text;
                String url = "http://localhost:8080/damroom/reservas/" + dni;
                metodoConsultar(url);
            }
            else if (tbHabi.Enabled)
            {
                int habitacion = int.Parse(tbHabi.Text);
                String url = "http://localhost:8080/damroom/reservas/" + habitacion;
                metodoConsultar(url);
            }
            else if (dtFechaIni.Enabled)
            {
                DateTime fechaIni = dtFechaIni.Value;
                String url = "http://localhost:8080/reservas/fechaIni" + fechaIni;
                metodoConsultar(url);
            }
            else if (dtFechaFin.Enabled)
            {
                DateTime fechaFin = dtFechaFin.Value;
                String url = "http://localhost:8080/reservas/fechaFinal" + fechaFin;
                metodoConsultar(url);
            }
            else if (tbImporte.Enabled)
            {
                float importe = float.Parse(tbImporte.Text, CultureInfo.InvariantCulture.NumberFormat);
                String url = "http://localhost:8080/reservas/" + importe;
                metodoConsultar(url);
            }
        }

        private void metodoConsultar(String url)
        {
            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
