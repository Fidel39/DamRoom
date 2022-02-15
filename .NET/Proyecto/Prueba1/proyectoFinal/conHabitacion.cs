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
            String url = "http://localhost:8080/damroom/habitaciones";

            conectar c = new conectar(url, "GET");
            String resultado = c.getItem();

            listViewLibres.Items.Add(resultado);
        }
    }

}
