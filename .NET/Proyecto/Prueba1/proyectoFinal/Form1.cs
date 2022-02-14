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

        private void enblaeSubmenuCliente()
        {
            btConCliente.Enabled = true;
            btBajaCli.Enabled = true;
            btAltaCli.Enabled = true;
            btModiCli.Enabled = true;
        }

        private void enableSubHabitacion()
        {
            btAltaHabi.Enabled = true;
            btBajaHabi.Enabled = true;
            btModiHabi.Enabled = true;
            btConHabi.Enabled = true;
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
            enableSubHabitacion();
            btConHabi.Enabled = false;
        }

        private void btConCliente_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new conCli());
            enblaeSubmenuCliente();
            btConCliente.Enabled = false;
        }

        private void btAltaCli_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new altaCli());
            enblaeSubmenuCliente();
            btAltaCli.Enabled = false;
        }

        private void btBajaCli_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new bajaClie());
            enblaeSubmenuCliente();
            btBajaCli.Enabled = false;
        }

        private void btModiCli_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new modiCli());
            enblaeSubmenuCliente();
            btModiCli.Enabled = false;
        }

        private void btAltaHabi_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new altaHabi());
            enableSubHabitacion();
            btAltaHabi.Enabled = false;
        }

        private void btBajaHabi_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new bajaHabi());
            enableSubHabitacion();
            btBajaHabi.Enabled = false;
        }

        private void btModiHabi_Click(object sender, EventArgs e)
        {
            abirFormularioHijos(new modHabi());
            enableSubHabitacion();
            btModiHabi.Enabled = false;
        }
    }
}
