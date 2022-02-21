using Newtonsoft.Json;
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

            String numHabi = cbHabi.SelectedItem.ToString();

            long idHabitacion = Int32.Parse(numHabi);
            float importe = float.Parse(tbImporte.Text);

            String dniCliente = cbDniCli.SelectedItem.ToString();
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

            String url2 = "http://localhost:8080/habitaciones/"+idHabitacion + "/modEstado";
            conectar c2 = new conectar(url2, "PUT");
            c2.putItemVacio(idHabitacion);

        }

        private void anyReserva_Load(object sender, EventArgs e)
        {
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

            String urlHabi  = "http://localhost:8080/damroom/habitaciones";

            conectar cHabi = new conectar(urlHabi, "GET");
            String resultadoHabi = cHabi.getItem();
            List<Habitacion> n = JsonConvert.DeserializeObject<List<Habitacion>>(resultadoHabi);
            long idRoom;

            for (int j = 0; j < n.Count; j++)
            {
                idRoom = n.ElementAt(j).IdRoom;
                cbHabi.Items.Add(idRoom);
            }
        }
    }
}
