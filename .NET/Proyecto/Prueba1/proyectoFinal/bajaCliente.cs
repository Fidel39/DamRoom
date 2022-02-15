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
    public partial class bajaClie : Form
    {
        public bajaClie()
        {
            InitializeComponent();
        }

        private void btEliminarCli_Click(object sender, EventArgs e)
        {
            String dni = tbDniCli.Text;

            String url = "http://localhost:8080/clientes/" + dni;

            conectar c = new conectar(url, "DELETE");

            c.deleteItem(dni);

            MessageBox.Show("Se ha eliminado correctamente");
        }
    }
}
