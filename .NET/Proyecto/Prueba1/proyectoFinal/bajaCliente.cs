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
    public partial class bajaClie : Form
    {
        public bajaClie()
        {
            InitializeComponent();
        }

        private void btEliminarCli_Click(object sender, EventArgs e)
        {
            String dni = cbDniCli.SelectedItem.ToString();

            String url = "http://localhost:8080/clientes/" + dni;

            conectar c = new conectar(url, "DELETE");

            c.deleteItem(dni);

            MessageBox.Show("Se ha eliminado correctamente");
        }

        private void bajaClie_Load(object sender, EventArgs e)
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
        }
    }
}
