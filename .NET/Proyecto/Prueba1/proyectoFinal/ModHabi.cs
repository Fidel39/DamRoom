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
    public partial class modHabi : Form
    {
        public modHabi()
        {
            InitializeComponent();
        }

        private void btModiHabi_Click(object sender, EventArgs e)
        {
            String numHabiAntes = cbHabi.SelectedItem.ToString();
            String caracteristicas = tbCaracteristicas.Text;
            String importe = tbImporte.Text;
            String tipo = tbTipo.Text;

            String url = "http://localhost:8080/habitaciones/" + numHabiAntes;

            conectar c = new conectar(url, "PUT");

            String datos = "{" +
               "\"caracteristicas\" : \"" + caracteristicas + "\", " +
               "\"importeNoche\" : \"" + importe + "\", " +
               "\"tipo\" : \"" + tipo + "\"" +
               "}";

            c.putItem(numHabiAntes, datos);

            MessageBox.Show("Se ha insertado correctamente.");
        }

        private void modHabi_Load(object sender, EventArgs e)
        {
            String urlHabi = "http://localhost:8080/damroom/habitaciones";

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
