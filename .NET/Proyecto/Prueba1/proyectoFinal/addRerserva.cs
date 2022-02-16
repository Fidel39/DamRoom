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
    public partial class anyReserva : Form
    {
        public anyReserva()
        {
            InitializeComponent();
        }

        private void btClienteNuevo_Click(object sender, EventArgs e)
        {
            gbCliente.Visible = true;
            gbReservas.Location = new Point(40, 240);
            lbDniCliRe.Visible = false;
            tbCliRe.Visible = false;
            btClienteNuevo.Enabled = false;
            btClienteExist.Enabled = true;
        }

        private void btClienteExist_Click(object sender, EventArgs e)
        {
            gbCliente.Visible = false;
            gbReservas.Location = new Point(40, 65);
            lbDniCliRe.Visible = true;
            tbCliRe.Visible = true;
            btClienteExist.Enabled = false;
            btClienteNuevo.Enabled = true;
        }

        private void anyCliente_Load(object sender, EventArgs e)
        {
            lbDniCliRe.Visible = false;
            tbCliRe.Visible = false;
        }

        private void btReservar_Click(object sender, EventArgs e)
        {
            String fehaIni = dateTimePicker1.Value.ToString();
            String fechaFin = dateTimePicker2.Value.ToString();
            String dniCliente = tbCliRe.Text;
            String DNICliente = textBox1.Text;
            String nombreCliente = textBox2.Text;
            String apellidosCliente = textBox3.Text;
            String direccionCliente = textBox4.Text;
            int telefonoCliente = Convert.ToInt32(textBox5.Text);
            long idHabitacion = Convert.ToInt64(tbHabRe.Text);
            float importe = float.Parse(textBox8.Text);

            String url = "http://localhost:8080/damroom/reservas";
            String url2 = "http://localhost:8080/habitaciones/"+idHabitacion+"/modEstado";

            conectar c = new conectar(url, "POST");
            conectar c1 = new conectar(url, "PUT");

            String datos = "{"+
                     "\"fechaFin\" : \"" + fechaFin + "\", " +
                    "\"fechaIni\" : \"" + fehaIni + "\", " +
                    "\"importe\" : \"" + importe + "\", " +
                    "\"estado\" : \"" + "Pendiente" +"\", " +

                        "cliente"+"{" +
                            "\"dni\" : \"" + DNICliente + "\", " +
                            "\"nombre\" : \"" + nombreCliente + "\", " +
                            "\"apellido\" : \"" + apellidosCliente + "\", " +
                            "\"direccion\" : \"" + direccionCliente + "\", " +
                            "\"telefono\" : \"" + telefonoCliente + "\" " +
                        "}," +

                        "habitacion"+"{" +
                            "\"idRoom\" : \"" + idHabitacion + "\", " +
                        "}," +
                    "\"dniCliente\" : \"" + DNICliente + "\", " +
                "}";


            String res = c.postItem(datos);
            //String res1 = c1.putItem();

            MessageBox.Show("Se ha insertado correctamente.");
        }
    }
}
