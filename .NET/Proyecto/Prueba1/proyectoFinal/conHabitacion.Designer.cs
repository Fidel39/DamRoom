namespace proyectoFinal
{
    partial class conHabitacion
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
            this.btVisualizarHabi = new System.Windows.Forms.Button();
            this.listViewOcupadas = new System.Windows.Forms.ListView();
            this.listViewLibres = new System.Windows.Forms.ListView();
            this.labOcupadas = new System.Windows.Forms.Label();
            this.labLibres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVisualizarHabi
            // 
            this.btVisualizarHabi.Location = new System.Drawing.Point(268, 85);
            this.btVisualizarHabi.Name = "btVisualizarHabi";
            this.btVisualizarHabi.Size = new System.Drawing.Size(75, 23);
            this.btVisualizarHabi.TabIndex = 13;
            this.btVisualizarHabi.Text = "Visualizar";
            this.btVisualizarHabi.UseVisualStyleBackColor = true;
            // 
            // listViewOcupadas
            // 
            this.listViewOcupadas.HideSelection = false;
            this.listViewOcupadas.Location = new System.Drawing.Point(377, 213);
            this.listViewOcupadas.Name = "listViewOcupadas";
            this.listViewOcupadas.Size = new System.Drawing.Size(235, 183);
            this.listViewOcupadas.TabIndex = 12;
            this.listViewOcupadas.UseCompatibleStateImageBehavior = false;
            // 
            // listViewLibres
            // 
            this.listViewLibres.HideSelection = false;
            this.listViewLibres.Location = new System.Drawing.Point(28, 213);
            this.listViewLibres.Name = "listViewLibres";
            this.listViewLibres.Size = new System.Drawing.Size(235, 183);
            this.listViewLibres.TabIndex = 11;
            this.listViewLibres.UseCompatibleStateImageBehavior = false;
            // 
            // labOcupadas
            // 
            this.labOcupadas.AutoSize = true;
            this.labOcupadas.Location = new System.Drawing.Point(437, 169);
            this.labOcupadas.Name = "labOcupadas";
            this.labOcupadas.Size = new System.Drawing.Size(121, 13);
            this.labOcupadas.TabIndex = 10;
            this.labOcupadas.Text = "Habitaciones Ocupadas";
            // 
            // labLibres
            // 
            this.labLibres.AutoSize = true;
            this.labLibres.Location = new System.Drawing.Point(92, 169);
            this.labLibres.Name = "labLibres";
            this.labLibres.Size = new System.Drawing.Size(100, 13);
            this.labLibres.TabIndex = 9;
            this.labLibres.Text = "Habitaciones Libres";
            // 
            // conHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 483);
            this.Controls.Add(this.btVisualizarHabi);
            this.Controls.Add(this.listViewOcupadas);
            this.Controls.Add(this.listViewLibres);
            this.Controls.Add(this.labOcupadas);
            this.Controls.Add(this.labLibres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "conHabitacion";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVisualizarHabi;
        private System.Windows.Forms.ListView listViewOcupadas;
        private System.Windows.Forms.ListView listViewLibres;
        private System.Windows.Forms.Label labOcupadas;
        private System.Windows.Forms.Label labLibres;
    }
}