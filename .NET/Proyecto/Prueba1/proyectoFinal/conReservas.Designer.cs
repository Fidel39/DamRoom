namespace proyectoFinal
{
    partial class conReservas
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
            this.btAtras = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            this.checkBoxIn = new System.Windows.Forms.CheckBox();
            this.labChechOut = new System.Windows.Forms.Label();
            this.labCheckIn = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labImporte = new System.Windows.Forms.Label();
            this.labFechFin = new System.Windows.Forms.Label();
            this.labFechIni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labHabit = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.lbDNICLiente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAtras
            // 
            this.btAtras.Location = new System.Drawing.Point(35, 393);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(75, 23);
            this.btAtras.TabIndex = 33;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(239, 393);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 32;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.AutoSize = true;
            this.checkBoxOut.Location = new System.Drawing.Point(114, 321);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOut.TabIndex = 31;
            this.checkBoxOut.UseVisualStyleBackColor = true;
            // 
            // checkBoxIn
            // 
            this.checkBoxIn.AutoSize = true;
            this.checkBoxIn.Location = new System.Drawing.Point(114, 279);
            this.checkBoxIn.Name = "checkBoxIn";
            this.checkBoxIn.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIn.TabIndex = 30;
            this.checkBoxIn.UseVisualStyleBackColor = true;
            // 
            // labChechOut
            // 
            this.labChechOut.AutoSize = true;
            this.labChechOut.Location = new System.Drawing.Point(35, 326);
            this.labChechOut.Name = "labChechOut";
            this.labChechOut.Size = new System.Drawing.Size(61, 13);
            this.labChechOut.TabIndex = 29;
            this.labChechOut.Text = "Check-Out:";
            // 
            // labCheckIn
            // 
            this.labCheckIn.AutoSize = true;
            this.labCheckIn.Location = new System.Drawing.Point(32, 279);
            this.labCheckIn.Name = "labCheckIn";
            this.labCheckIn.Size = new System.Drawing.Size(53, 13);
            this.labCheckIn.TabIndex = 28;
            this.labCheckIn.Text = "Check-In:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 185);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(365, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(270, 365);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 24;
            // 
            // labImporte
            // 
            this.labImporte.AutoSize = true;
            this.labImporte.Location = new System.Drawing.Point(29, 226);
            this.labImporte.Name = "labImporte";
            this.labImporte.Size = new System.Drawing.Size(45, 13);
            this.labImporte.TabIndex = 23;
            this.labImporte.Text = "Importe:";
            // 
            // labFechFin
            // 
            this.labFechFin.AutoSize = true;
            this.labFechFin.Location = new System.Drawing.Point(26, 185);
            this.labFechFin.Name = "labFechFin";
            this.labFechFin.Size = new System.Drawing.Size(69, 13);
            this.labFechFin.TabIndex = 22;
            this.labFechFin.Text = "Fecha de fin:";
            // 
            // labFechIni
            // 
            this.labFechIni.AutoSize = true;
            this.labFechIni.Location = new System.Drawing.Point(26, 140);
            this.labFechIni.Name = "labFechIni";
            this.labFechIni.Size = new System.Drawing.Size(82, 13);
            this.labFechIni.TabIndex = 21;
            this.labFechIni.Text = "Fecha de inicio:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 20;
            // 
            // labHabit
            // 
            this.labHabit.AutoSize = true;
            this.labHabit.Location = new System.Drawing.Point(26, 94);
            this.labHabit.Name = "labHabit";
            this.labHabit.Size = new System.Drawing.Size(61, 13);
            this.labHabit.TabIndex = 19;
            this.labHabit.Text = "Habitacion:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(114, 51);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 20);
            this.textID.TabIndex = 18;
            // 
            // lbDNICLiente
            // 
            this.lbDNICLiente.AutoSize = true;
            this.lbDNICLiente.Location = new System.Drawing.Point(26, 51);
            this.lbDNICLiente.Name = "lbDNICLiente";
            this.lbDNICLiente.Size = new System.Drawing.Size(64, 13);
            this.lbDNICLiente.TabIndex = 17;
            this.lbDNICLiente.Text = "DNI Cliente:";
            // 
            // conReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.checkBoxOut);
            this.Controls.Add(this.checkBoxIn);
            this.Controls.Add(this.labChechOut);
            this.Controls.Add(this.labCheckIn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labImporte);
            this.Controls.Add(this.labFechFin);
            this.Controls.Add(this.labFechIni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labHabit);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.lbDNICLiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conReservas";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.CheckBox checkBoxOut;
        private System.Windows.Forms.CheckBox checkBoxIn;
        private System.Windows.Forms.Label labChechOut;
        private System.Windows.Forms.Label labCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labImporte;
        private System.Windows.Forms.Label labFechFin;
        private System.Windows.Forms.Label labFechIni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labHabit;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label lbDNICLiente;
    }
}