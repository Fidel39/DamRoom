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
    public partial class modiCli : Form
    {
        public modiCli()
        {
            InitializeComponent();
        }

        private void btInserCli_Click(object sender, EventArgs e)
        {
            String dniAntes = tbDNI.Text;
            String dniModi = tbDniModi.Text;
            String nombreModi = tbNombre.Text;
            String apellidoModi = tbApellidos.Text;
            String direccionModi = tbDireccion.Text;
            int telefonoModi = Int32.Parse(tbTelefono.Text);

            String url = "http://localhost:8080/clientes/" + dniAntes;

            conectar c = new conectar(url, "PUT");

            String datos = "{" +
               "\"dni\" : \"" + dniModi + "\", " +
               "\"nombre\" : \"" + nombreModi + "\", " +
               "\"apellido\" : \"" + apellidoModi + "\", " +
               "\"direccion\" : \"" + direccionModi + "\", " +
               "\"telefono\" : \"" + telefonoModi + "\" " +
               "}";

            c.putItem(dniAntes, datos);

            MessageBox.Show("Se ha insertado correctamente.");
        }
    }
}
