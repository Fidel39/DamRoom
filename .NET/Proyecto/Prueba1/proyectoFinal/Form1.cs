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
    public partial class DamRoom : Form
    {
        public DamRoom()
        {
            InitializeComponent();
        }

        private void abirFormularioHijos(object formularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0) {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form formHijo = formularioHijo as Form;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void enables()
        {
            btAnyReser.Enabled = true;
            btConReser.Enabled = true;
            btHabi.Enabled = true;
            btCliente.Enabled = true;
        }

        private void ocultarSubmenu()
        {
            panelSubCliente.Visible = false;
            panelSubHabi.Visible = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btAnyReser_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new anyReserva());
            enables();
            btAnyReser.Enabled = false;
            ocultarSubmenu();
        }

        private void btConReser_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new conReservas());
            enables();
            btConReser.Enabled = false;
            ocultarSubmenu();
        }

        private void btConClien_Click(object sender, EventArgs e)
        {
            //btConClien.Enabled = false;
        }

        private void DamRoom_Load(object sender, EventArgs e)
        {
            ocultarSubmenu();
        }

        private void btCliente_Click(object sender, EventArgs e)
        {
            panelSubCliente.Visible = true;
            panelSubHabi.Visible = false;
            enables();
            btCliente.Enabled = false;
            
        }

        private void btConHabi_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new conHabitacion());
        }

        private void btHabi_Click(object sender, EventArgs e)
        {
            panelSubCliente.Visible = false;
            panelSubHabi.Visible = true;
            enables();
            btHabi.Enabled = false;
            
        }

        private void btConHabi_Click_1(object sender, EventArgs e)
        {
            abirFormularioHijos(new conHabitacion());
        }
    }
}
