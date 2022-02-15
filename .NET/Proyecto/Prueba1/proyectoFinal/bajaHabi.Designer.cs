
namespace proyectoFinal
{
    partial class bajaHabi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labPregunta = new System.Windows.Forms.Label();
            this.tbNumHabi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBajaHabi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labPregunta);
            this.groupBox1.Controls.Add(this.tbNumHabi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 130);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de baja una habitacion";
            // 
            // labPregunta
            // 
            this.labPregunta.AutoSize = true;
            this.labPregunta.Location = new System.Drawing.Point(129, 34);
            this.labPregunta.Name = "labPregunta";
            this.labPregunta.Size = new System.Drawing.Size(358, 13);
            this.labPregunta.TabIndex = 0;
            this.labPregunta.Text = "Que habitacion quieres dar de baja? Introduzca el numero de la habitacion";
            // 
            // tbNumHabi
            // 
            this.tbNumHabi.Location = new System.Drawing.Point(254, 80);
            this.tbNumHabi.Name = "tbNumHabi";
            this.tbNumHabi.Size = new System.Drawing.Size(180, 20);
            this.tbNumHabi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NºHabitacion:";
            // 
            // btBajaHabi
            // 
            this.btBajaHabi.Location = new System.Drawing.Point(567, 451);
            this.btBajaHabi.Name = "btBajaHabi";
            this.btBajaHabi.Size = new System.Drawing.Size(75, 23);
            this.btBajaHabi.TabIndex = 5;
            this.btBajaHabi.Text = "Eliminar";
            this.btBajaHabi.UseVisualStyleBackColor = true;
            this.btBajaHabi.Click += new System.EventHandler(this.btBajaHabi_Click);
            // 
            // bajaHabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btBajaHabi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bajaHabi";
            this.Text = "Form10";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labPregunta;
        private System.Windows.Forms.TextBox tbNumHabi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBajaHabi;
    }
}