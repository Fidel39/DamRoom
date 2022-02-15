
namespace proyectoFinal
{
    partial class altaCli
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
            this.labInDNI = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbApeliidos = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.labDire = new System.Windows.Forms.Label();
            this.btInserCli = new System.Windows.Forms.Button();
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupBoxCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // labInDNI
            // 
            this.labInDNI.AutoSize = true;
            this.labInDNI.Location = new System.Drawing.Point(27, 32);
            this.labInDNI.Name = "labInDNI";
            this.labInDNI.Size = new System.Drawing.Size(29, 13);
            this.labInDNI.TabIndex = 0;
            this.labInDNI.Text = "DNI:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(62, 29);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(162, 20);
            this.tbDNI.TabIndex = 1;
            // 
            // tbApeliidos
            // 
            this.tbApeliidos.Location = new System.Drawing.Point(85, 105);
            this.tbApeliidos.Name = "tbApeliidos";
            this.tbApeliidos.Size = new System.Drawing.Size(139, 20);
            this.tbApeliidos.TabIndex = 3;
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(27, 108);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(52, 13);
            this.labApellidos.TabIndex = 2;
            this.labApellidos.Text = "Apellidos:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(332, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(253, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(271, 32);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(47, 13);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "Nombre:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(85, 175);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(139, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(27, 178);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(52, 13);
            this.labTelefono.TabIndex = 6;
            this.labTelefono.Text = "Telefono:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(332, 105);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(253, 20);
            this.tbDireccion.TabIndex = 9;
            // 
            // labDire
            // 
            this.labDire.AutoSize = true;
            this.labDire.Location = new System.Drawing.Point(271, 108);
            this.labDire.Name = "labDire";
            this.labDire.Size = new System.Drawing.Size(55, 13);
            this.labDire.TabIndex = 8;
            this.labDire.Text = "Direccion:";
            // 
            // btInserCli
            // 
            this.btInserCli.Location = new System.Drawing.Point(466, 458);
            this.btInserCli.Name = "btInserCli";
            this.btInserCli.Size = new System.Drawing.Size(75, 23);
            this.btInserCli.TabIndex = 10;
            this.btInserCli.Text = "Insertar";
            this.btInserCli.UseVisualStyleBackColor = true;
            this.btInserCli.Click += new System.EventHandler(this.btInserCli_Click);
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.labDire);
            this.groupBoxCli.Controls.Add(this.labInDNI);
            this.groupBoxCli.Controls.Add(this.tbDireccion);
            this.groupBoxCli.Controls.Add(this.tbDNI);
            this.groupBoxCli.Controls.Add(this.labApellidos);
            this.groupBoxCli.Controls.Add(this.tbTelefono);
            this.groupBoxCli.Controls.Add(this.tbApeliidos);
            this.groupBoxCli.Controls.Add(this.labTelefono);
            this.groupBoxCli.Controls.Add(this.labNombre);
            this.groupBoxCli.Controls.Add(this.tbNombre);
            this.groupBoxCli.Location = new System.Drawing.Point(24, 131);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(619, 225);
            this.groupBoxCli.TabIndex = 11;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "Insertar Cliente";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(568, 458);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // altaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.groupBoxCli);
            this.Controls.Add(this.btInserCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "altaCli";
            this.Text = "Form6";
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labInDNI;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbApeliidos;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label labDire;
        private System.Windows.Forms.Button btInserCli;
        private System.Windows.Forms.GroupBox groupBoxCli;
        private System.Windows.Forms.Button btSalir;
    }
}