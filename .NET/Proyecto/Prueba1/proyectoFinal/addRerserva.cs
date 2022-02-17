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

        private void btReservar_Click(object sender, EventArgs e)
        {

            DateTime fehaIni = dtFechaIni.Value;
            String fi = fehaIni.ToString("yyyy-MM-dd");

            DateTime fechaFin = dtFechaFin.Value;
            String ff = fechaFin.ToString("yyyy-MM-dd");

            long idHabitacion = Convert.ToInt64(tbHabRe.Text);
            float importe = float.Parse(tbImporte.Text);
            String dniCliente = tbCliRe.Text;
            Console.WriteLine(fehaIni);
            String url = "http://localhost:8080/damroom/reservas";

            conectar c = new conectar(url, "POST");

            String datos = "{" +
                "\"dniCliente\" : \"" + dniCliente + "\", " +
                 "\"estado\" : \"" + "Pendiente" + "\", " +
                "\"fechaFin\" : \"" + ff + "\", " +
                "\"fechaIni\" : \"" + fi + "\", " +
                "\"importe\" : \"" + importe + "\", " +
                "\"cliente\" :{"+"\"dni\" : \"" +dniCliente+"\""+"},"+
                "\"habitacion\" :{" + "\"idRoom\" : \"" + idHabitacion + "\"" + "}" +
                "}";


            String res = c.postItem(datos);

            MessageBox.Show("Se ha insertado correctamente.");

            String url2 = "http://localhost:8080/habitaciones/"+idHabitacion +"/tramite";
            conectar c2 = new conectar(url2, "PUT");

        }
    }
}
