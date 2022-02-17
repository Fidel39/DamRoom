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
            String numHabiAntes = tbNumHabi.Text;
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
    }
}
