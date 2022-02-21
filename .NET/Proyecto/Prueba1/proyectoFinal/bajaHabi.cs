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
    public partial class bajaHabi : Form
    {
        public bajaHabi()
        {
            InitializeComponent();
        }

        private void btBajaHabi_Click(object sender, EventArgs e)
        {
            String idHabi = cbHabi.SelectedItem.ToString();

            String url = "http://localhost:8080/habitaciones/" + idHabi;

            conectar c = new conectar(url, "DELETE");

            c.deleteItem(idHabi);

            MessageBox.Show("Se ha eliminado correctamente");
        }

        private void btBajaHabi_Click_1(object sender, EventArgs e)
        {

        }

        private void bajaHabi_Load(object sender, EventArgs e)
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
