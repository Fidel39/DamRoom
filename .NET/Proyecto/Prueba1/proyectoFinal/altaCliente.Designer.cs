
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labDire = new System.Windows.Forms.Label();
            this.btInserCli = new System.Windows.Forms.Button();
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 20);
            this.textBox3.TabIndex = 5;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 7;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(332, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(253, 20);
            this.textBox5.TabIndex = 9;
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
            this.btInserCli.Location = new System.Drawing.Point(568, 445);
            this.btInserCli.Name = "btInserCli";
            this.btInserCli.Size = new System.Drawing.Size(75, 23);
            this.btInserCli.TabIndex = 10;
            this.btInserCli.Text = "Insertar";
            this.btInserCli.UseVisualStyleBackColor = true;
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.labDire);
            this.groupBoxCli.Controls.Add(this.labInDNI);
            this.groupBoxCli.Controls.Add(this.textBox5);
            this.groupBoxCli.Controls.Add(this.textBox1);
            this.groupBoxCli.Controls.Add(this.labApellidos);
            this.groupBoxCli.Controls.Add(this.textBox4);
            this.groupBoxCli.Controls.Add(this.textBox2);
            this.groupBoxCli.Controls.Add(this.labTelefono);
            this.groupBoxCli.Controls.Add(this.labNombre);
            this.groupBoxCli.Controls.Add(this.textBox3);
            this.groupBoxCli.Location = new System.Drawing.Point(24, 131);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(619, 225);
            this.groupBoxCli.TabIndex = 11;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "Insertar Cliente";
            // 
            // altaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labDire;
        private System.Windows.Forms.Button btInserCli;
        private System.Windows.Forms.GroupBox groupBoxCli;
    }
}