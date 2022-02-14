
namespace proyectoFinal
{
    partial class altaHabi
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
            this.groupBoxCli = new System.Windows.Forms.GroupBox();
            this.labDire = new System.Windows.Forms.Label();
            this.labInDNI = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btInserHabi = new System.Windows.Forms.Button();
            this.groupBoxCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCli
            // 
            this.groupBoxCli.Controls.Add(this.labDire);
            this.groupBoxCli.Controls.Add(this.labInDNI);
            this.groupBoxCli.Controls.Add(this.textBox5);
            this.groupBoxCli.Controls.Add(this.textBox1);
            this.groupBoxCli.Controls.Add(this.labApellidos);
            this.groupBoxCli.Controls.Add(this.textBox2);
            this.groupBoxCli.Controls.Add(this.labNombre);
            this.groupBoxCli.Controls.Add(this.textBox3);
            this.groupBoxCli.Location = new System.Drawing.Point(25, 149);
            this.groupBoxCli.Name = "groupBoxCli";
            this.groupBoxCli.Size = new System.Drawing.Size(619, 176);
            this.groupBoxCli.TabIndex = 12;
            this.groupBoxCli.TabStop = false;
            this.groupBoxCli.Text = "Insertar Habitación";
            // 
            // labDire
            // 
            this.labDire.AutoSize = true;
            this.labDire.Location = new System.Drawing.Point(297, 108);
            this.labDire.Name = "labDire";
            this.labDire.Size = new System.Drawing.Size(31, 13);
            this.labDire.TabIndex = 8;
            this.labDire.Text = "Tipo:";
            // 
            // labInDNI
            // 
            this.labInDNI.AutoSize = true;
            this.labInDNI.Location = new System.Drawing.Point(27, 32);
            this.labInDNI.Name = "labInDNI";
            this.labInDNI.Size = new System.Drawing.Size(21, 13);
            this.labInDNI.TabIndex = 0;
            this.labInDNI.Text = "ID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(334, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(27, 108);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(45, 13);
            this.labApellidos.TabIndex = 2;
            this.labApellidos.Text = "Importe:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(249, 32);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(79, 13);
            this.labNombre.TabIndex = 4;
            this.labNombre.Text = "Caracteristicas:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(332, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(251, 20);
            this.textBox3.TabIndex = 5;
            // 
            // btInserHabi
            // 
            this.btInserHabi.Location = new System.Drawing.Point(539, 440);
            this.btInserHabi.Name = "btInserHabi";
            this.btInserHabi.Size = new System.Drawing.Size(75, 23);
            this.btInserHabi.TabIndex = 13;
            this.btInserHabi.Text = "Insertar";
            this.btInserHabi.UseVisualStyleBackColor = true;
            // 
            // altaHabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btInserHabi);
            this.Controls.Add(this.groupBoxCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "altaHabi";
            this.Text = "Form9";
            this.groupBoxCli.ResumeLayout(false);
            this.groupBoxCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCli;
        private System.Windows.Forms.Label labDire;
        private System.Windows.Forms.Label labInDNI;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btInserHabi;
    }
}