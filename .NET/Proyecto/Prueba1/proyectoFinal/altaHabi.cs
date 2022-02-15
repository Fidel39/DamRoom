using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class altaHabi : Form
    {
        public altaHabi()
        {
            InitializeComponent();
        }

        private void btInserHabi_Click(object sender, EventArgs e)
        {
            String caracteristicas = tbCaracteristicas.Text;
            float importe = float.Parse(tbImporte.Text, CultureInfo.InvariantCulture.NumberFormat);
            String tipo = tbTipo.Text;

            String urlHabi = "http://localhost:8080/damroom/habitaciones";

            conectar cHabi = new conectar(urlHabi, "POST");

            String datos = "{" +
                "\"caracteristicas\" : \"" + caracteristicas + "\", " +
                "\"importeNoche\" : \"" + importe + "\", " +
                "\"tipo\" : \"" + tipo + "\"" +
                "}";

            String res = cHabi.postItem(datos);


            MessageBox.Show("Se ha insertado correctamente.");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
