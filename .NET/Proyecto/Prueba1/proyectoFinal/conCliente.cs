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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Cliente cliente;
            String dni = cbDniCli.SelectedItem.ToString();
            String url = "http://localhost:8080/clientes/" + dni;

            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();
            Cliente m = JsonConvert.DeserializeObject<Cliente>(resultado);
            String Dni;
            String nombre;
            String apellidos;
            String direccion;
            int telefono;

            Dni = m.Dni;
            nombre = m.Nombre;
            apellidos = m.Apellidos;
            direccion = m.Direccion;
            telefono = m.Telefono;

            dataGridView1.Rows.Add(Dni, nombre, apellidos, direccion, telefono);
        }

        private void conCli_Load(object sender, EventArgs e)
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
