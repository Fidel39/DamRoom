using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btConReservas_Click(object sender, EventArgs e)
        {
            Form formulario = new conReservas();
            formulario.Show();
        }

        private void btAReservas_Click(object sender, EventArgs e)
        {
            Form formulario = new anyadReservas();
            formulario.Show();
        }

        private void btConHabitacion_Click(object sender, EventArgs e)
        {
            Form formulario = new conHabitacion();
            formulario.Show();
        }

        private void btConCliente_Click(object sender, EventArgs e)
        {
            Form formulario = new conCliente();
            formulario.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            imGif.Image = Image.FromFile("C:\\Users\\dam_ftb\\Downloads\\Proyecto\\Proyecto\\gif.gif");
            imGif.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
