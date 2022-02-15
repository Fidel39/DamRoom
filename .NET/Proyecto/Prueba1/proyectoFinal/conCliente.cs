using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace proyectoFinal
{
    public partial class conCli : Form
    {
        public conCli()
        {
            InitializeComponent();
        }

        class Cliente
        {
            public String dni { set; get; }
            public String nombre { set; get; }
            public String apellido { set; get; }
            public String direccion { set; get; }
            public int telefono { set; get; }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            String dni = tBdniCli.Text;
            String url = "http://localhost:8080/clientes/" + dni;

            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();
            Cliente cl = JsonConvert.DeserializeObject<Cliente>(resultado);

            listViewClientes.Items.Add(resultado);
        }
    }
}
