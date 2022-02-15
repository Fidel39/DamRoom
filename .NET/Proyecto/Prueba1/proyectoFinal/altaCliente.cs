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
    public partial class altaCli : Form
    {
        public altaCli()
        {
            InitializeComponent();
        }

        private void btInserCli_Click(object sender, EventArgs e)
        {
            String dni = tbDNI.Text;
            String nombre = tbNombre.Text;
            String apellido = tbApeliidos.Text;
            String direccion = tbDireccion.Text;
            int telefono = Int32.Parse(tbTelefono.Text);

            String url = "http://localhost:8080/damroom/clientes";

            conectar c = new conectar(url, "POST");

            String datos = "{" +
                "\"dni\" : \"" + dni + "\", " +
                "\"nombre\" : \"" + nombre + "\", " +
                "\"apellido\" : \"" + apellido + "\", " +
                "\"direccion\" : \"" + direccion + "\", " +
                "\"telefono\" : \"" + telefono + "\" " +
                "}";

            String res = c.postItem(datos);

            MessageBox.Show("Se ha insertado correctamente.");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
