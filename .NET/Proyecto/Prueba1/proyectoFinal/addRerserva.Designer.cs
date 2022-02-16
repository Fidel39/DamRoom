namespace proyectoFinal
{
    partial class anyReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btClienteExist = new System.Windows.Forms.Button();
            this.btClienteNuevo = new System.Windows.Forms.Button();
            this.btReservar = new System.Windows.Forms.Button();
            this.gbReservas = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbImporte = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbCliRe = new System.Windows.Forms.TextBox();
            this.lbDniCliRe = new System.Windows.Forms.Label();
            this.tbHabRe = new System.Windows.Forms.TextBox();
            this.lbFechaIni = new System.Windows.Forms.Label();
            this.lbNumHab = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.gbReservas.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btClienteExist
            // 
            this.btClienteExist.FlatAppearance.BorderSize = 0;
            this.btClienteExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteExist.Location = new System.Drawing.Point(151, 31);
            this.btClienteExist.Name = "btClienteExist";
            this.btClienteExist.Size = new System.Drawing.Size(103, 23);
            this.btClienteExist.TabIndex = 14;
            this.btClienteExist.Text = "Cliente Existente";
            this.btClienteExist.UseVisualStyleBackColor = true;
            this.btClienteExist.Click += new System.EventHandler(this.btClienteExist_Click);
            // 
            // btClienteNuevo
            // 
            this.btClienteNuevo.Enabled = false;
            this.btClienteNuevo.FlatAppearance.BorderSize = 0;
            this.btClienteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClienteNuevo.Location = new System.Drawing.Point(29, 31);
            this.btClienteNuevo.Name = "btClienteNuevo";
            this.btClienteNuevo.Size = new System.Drawing.Size(93, 23);
            this.btClienteNuevo.TabIndex = 13;
            this.btClienteNuevo.Text = "Cliente Nuevo";
            this.btClienteNuevo.UseVisualStyleBackColor = true;
            this.btClienteNuevo.Click += new System.EventHandler(this.btClienteNuevo_Click);
            // 
            // btReservar
            // 
            this.btReservar.Location = new System.Drawing.Point(565, 417);
            this.btReservar.Name = "btReservar";
            this.btReservar.Size = new System.Drawing.Size(75, 23);
            this.btReservar.TabIndex = 12;
            this.btReservar.Text = "Reservar";
            this.btReservar.UseVisualStyleBackColor = true;
            this.btReservar.Click += new System.EventHandler(this.btReservar_Click);
            // 
            // gbReservas
            // 
            this.gbReservas.Controls.Add(this.textBox8);
            this.gbReservas.Controls.Add(this.lbImporte);
            this.gbReservas.Controls.Add(this.dateTimePicker2);
            this.gbReservas.Controls.Add(this.lbFechaFin);
            this.gbReservas.Controls.Add(this.dateTimePicker1);
            this.gbReservas.Controls.Add(this.tbCliRe);
            this.gbReservas.Controls.Add(this.lbDniCliRe);
            this.gbReservas.Controls.Add(this.tbHabRe);
            this.gbReservas.Controls.Add(this.lbFechaIni);
            this.gbReservas.Controls.Add(this.lbNumHab);
            this.gbReservas.Location = new System.Drawing.Point(29, 232);
            this.gbReservas.Name = "gbReservas";
            this.gbReservas.Size = new System.Drawing.Size(611, 140);
            this.gbReservas.TabIndex = 10;
            this.gbReservas.TabStop = false;
            this.gbReservas.Text = "Datos Reserva";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(444, 36);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(151, 20);
            this.textBox8.TabIndex = 10;
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Location = new System.Drawing.Point(393, 39);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(45, 13);
            this.lbImporte.TabIndex = 9;
            this.lbImporte.Text = "Importe:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(396, 90);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Location = new System.Drawing.Point(338, 96);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(57, 13);
            this.lbFechaFin.TabIndex = 7;
            this.lbFechaFin.Text = "Fecha Fin:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tbCliRe
            // 
            this.tbCliRe.Location = new System.Drawing.Point(277, 39);
            this.tbCliRe.Name = "tbCliRe";
            this.tbCliRe.Size = new System.Drawing.Size(83, 20);
            this.tbCliRe.TabIndex = 5;
            // 
            // lbDniCliRe
            // 
            this.lbDniCliRe.AutoSize = true;
            this.lbDniCliRe.Location = new System.Drawing.Point(208, 39);
            this.lbDniCliRe.Name = "lbDniCliRe";
            this.lbDniCliRe.Size = new System.Drawing.Size(63, 13);
            this.lbDniCliRe.TabIndex = 4;
            this.lbDniCliRe.Text = "DNI cliente:";
            // 
            // tbHabRe
            // 
            this.tbHabRe.Location = new System.Drawing.Point(96, 36);
            this.tbHabRe.Name = "tbHabRe";
            this.tbHabRe.Size = new System.Drawing.Size(62, 20);
            this.tbHabRe.TabIndex = 3;
            // 
            // lbFechaIni
            // 
            this.lbFechaIni.AutoSize = true;
            this.lbFechaIni.Location = new System.Drawing.Point(17, 96);
            this.lbFechaIni.Name = "lbFechaIni";
            this.lbFechaIni.Size = new System.Drawing.Size(68, 13);
            this.lbFechaIni.TabIndex = 2;
            this.lbFechaIni.Text = "Fecha Inicio:";
            // 
            // lbNumHab
            // 
            this.lbNumHab.AutoSize = true;
            this.lbNumHab.Location = new System.Drawing.Point(17, 39);
            this.lbNumHab.Name = "lbNumHab";
            this.lbNumHab.Size = new System.Drawing.Size(73, 13);
            this.lbNumHab.TabIndex = 0;
            this.lbNumHab.Text = "NºHabitacion:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.textBox5);
            this.gbCliente.Controls.Add(this.lbTelefono);
            this.gbCliente.Controls.Add(this.textBox4);
            this.gbCliente.Controls.Add(this.lbDireccion);
            this.gbCliente.Controls.Add(this.textBox3);
            this.gbCliente.Controls.Add(this.lbApellidos);
            this.gbCliente.Controls.Add(this.textBox2);
            this.gbCliente.Controls.Add(this.lbNombre);
            this.gbCliente.Controls.Add(this.textBox1);
            this.gbCliente.Controls.Add(this.lbDNI);
            this.gbCliente.Location = new System.Drawing.Point(29, 74);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(611, 126);
            this.gbCliente.TabIndex = 9;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Cliente";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(444, 76);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 9;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(386, 79);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 8;
            this.lbTelefono.Text = "Telefono:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 20);
            this.textBox4.TabIndex = 7;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(17, 79);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 6;
            this.lbDireccion.Text = "Direccion:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(444, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(386, 29);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(52, 13);
            this.lbApellidos.TabIndex = 4;
            this.lbApellidos.Text = "Apellidos:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(189, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(17, 29);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(29, 13);
            this.lbDNI.TabIndex = 0;
            this.lbDNI.Text = "DNI:";
            // 
            // anyReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btClienteExist);
            this.Controls.Add(this.btClienteNuevo);
            this.Controls.Add(this.btReservar);
            this.Controls.Add(this.gbReservas);
            this.Controls.Add(this.gbCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "anyReserva";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.anyCliente_Load);
            this.gbReservas.ResumeLayout(false);
            this.gbReservas.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClienteExist;
        private System.Windows.Forms.Button btClienteNuevo;
        private System.Windows.Forms.Button btReservar;
        private System.Windows.Forms.GroupBox gbReservas;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbFechaFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbCliRe;
        private System.Windows.Forms.Label lbDniCliRe;
        private System.Windows.Forms.TextBox tbHabRe;
        private System.Windows.Forms.Label lbFechaIni;
        private System.Windows.Forms.Label lbNumHab;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDNI;
    }
}