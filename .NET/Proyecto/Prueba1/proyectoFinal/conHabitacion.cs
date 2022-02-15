using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace proyectoFinal
{
    public partial class conHabitacion : Form
    {
        public conHabitacion()
        {
            InitializeComponent();
        }

        private void btVisualizarHabi_Click(object sender, EventArgs e)
        {
            Habitacion habitacion;
            String url = "http://localhost:8080/damroom/habitaciones";

            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();
            List<Habitacion> m = JsonConvert.DeserializeObject<List<Habitacion>>(resultado);
            long idRoom;
            String caracteristicas, tipo, estado;
            float importe;
            for (int i = 0; i < m.Count; i++) {
               
                idRoom = m.ElementAt(i).IdRoom;
                tipo = m.ElementAt(i).Tipo;
                caracteristicas = m.ElementAt(i).Caracteristicas;
                importe = m.ElementAt(i).ImporteNoche;
                estado = m.ElementAt(i).Estado;

                if (estado.Equals("Libre")) {
                    dataGridView1.Rows.Add(idRoom, tipo, caracteristicas, importe);
                } else if (estado.Equals("Ocupada")) {
                    dataGridView2.Rows.Add(idRoom, tipo, caracteristicas, importe);
                }

                

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
