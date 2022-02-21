using Newtonsoft.Json;
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

        private void btDniCli_Click(object sender, EventArgs e)
        {
            enable();
            cbDniCli.Enabled = true;
        }

        private void conReservas_Load(object sender, EventArgs e)
        {
            enable();

            String url = "http://localhost:8080/damroom/clientes";

            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();
            List<Cliente> m = JsonConvert.DeserializeObject<List<Cliente>>(resultado);
            String Dni;

            for (int i = 0; i < m.Count; i++)
            {
                Dni = m.ElementAt(i).Dni;
                cbDniCli.Items.Add(Dni);
            }
        }

        private void enable()
        {
            cbDniCli.Enabled = false;
            tbImporte.Enabled = false;
            dtFechaFin.Enabled = false;
            dtFechaIni.Enabled = false;
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
            if(cbDniCli.Enabled)
            {
                String dni = cbDniCli.SelectedItem.ToString();
                String url = "http://localhost:8080/damroom/reservas/" + dni;
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
            List<Reserva> m = JsonConvert.DeserializeObject<List<Reserva>>(resultado);
            long idReserva;
            DateTime fi, ff;
            float importe;
            String dniCli;
            long numHabi;
            string estado;

            for(int i = 0; i < m.Count; i++)
            {
                idReserva = m.ElementAt(i).IdReserva;
                dniCli = m.ElementAt(i).DniCliente;
                estado = m.ElementAt(i).Estado;
                ff = m.ElementAt(i).FechaFin;
                fi = m.ElementAt(i).FechaIni;
                importe = m.ElementAt(i).Importe;
                numHabi = m.ElementAt(i).NumHabi;

                dgReserva.Rows.Add(idReserva, dniCli, estado, ff, fi, importe, numHabi);
            }


        }
    }
}
