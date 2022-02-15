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
    public partial class bajaHabi : Form
    {
        public bajaHabi()
        {
            InitializeComponent();
        }

        private void btBajaHabi_Click(object sender, EventArgs e)
        {
            String idHabi = tbNumHabi.Text;

            String url = "http://localhost:8080/habitaciones/" + idHabi;

            conectar c = new conectar(url, "DELETE");

            c.deleteItem(idHabi);

            MessageBox.Show("Se ha eliminado correctamente");
        }
    }
}
