
namespace proyectoFinal
{
    partial class bajaClie
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
            this.labPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEliminarCli = new System.Windows.Forms.Button();
            this.cbDniCli = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labPregunta
            // 
            this.labPregunta.AutoSize = true;
            this.labPregunta.Location = new System.Drawing.Point(166, 36);
            this.labPregunta.Name = "labPregunta";
            this.labPregunta.Size = new System.Drawing.Size(249, 13);
            this.labPregunta.TabIndex = 0;
            this.labPregunta.Text = "Que cliente quieres dar de baja? Introduzca su DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDniCli);
            this.groupBox1.Controls.Add(this.labPregunta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar de baja cliente";
            // 
            // btEliminarCli
            // 
            this.btEliminarCli.FlatAppearance.BorderSize = 0;
            this.btEliminarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminarCli.Image = global::proyectoFinal.Properties.Resources.delete__2_;
            this.btEliminarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminarCli.Location = new System.Drawing.Point(561, 433);
            this.btEliminarCli.Name = "btEliminarCli";
            this.btEliminarCli.Size = new System.Drawing.Size(81, 34);
            this.btEliminarCli.TabIndex = 4;
            this.btEliminarCli.Text = "Eliminar";
            this.btEliminarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminarCli.UseVisualStyleBackColor = true;
            this.btEliminarCli.Click += new System.EventHandler(this.btEliminarCli_Click);
            // 
            // cbDniCli
            // 
            this.cbDniCli.FormattingEnabled = true;
            this.cbDniCli.Location = new System.Drawing.Point(201, 83);
            this.cbDniCli.Name = "cbDniCli";
            this.cbDniCli.Size = new System.Drawing.Size(214, 21);
            this.cbDniCli.TabIndex = 5;
            this.cbDniCli.Text = "DNI Cliente";
            // 
            // bajaClie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btEliminarCli);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bajaClie";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.bajaClie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEliminarCli;
        private System.Windows.Forms.ComboBox cbDniCli;
    }
}