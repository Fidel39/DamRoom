
namespace Prueba1
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
            this.listViewOcupadas = new System.Windows.Forms.ListView();
            this.listViewLibres = new System.Windows.Forms.ListView();
            this.labOcupadas = new System.Windows.Forms.Label();
            this.labLibres = new System.Windows.Forms.Label();
            this.btVisualizarHabi = new System.Windows.Forms.Button();
            this.gbHabiVis = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // listViewOcupadas
            // 
            this.listViewOcupadas.HideSelection = false;
            this.listViewOcupadas.Location = new System.Drawing.Point(458, 88);
            this.listViewOcupadas.Name = "listViewOcupadas";
            this.listViewOcupadas.Size = new System.Drawing.Size(289, 196);
            this.listViewOcupadas.TabIndex = 7;
            this.listViewOcupadas.UseCompatibleStateImageBehavior = false;
            // 
            // listViewLibres
            // 
            this.listViewLibres.HideSelection = false;
            this.listViewLibres.Location = new System.Drawing.Point(66, 88);
            this.listViewLibres.Name = "listViewLibres";
            this.listViewLibres.Size = new System.Drawing.Size(289, 196);
            this.listViewLibres.TabIndex = 6;
            this.listViewLibres.UseCompatibleStateImageBehavior = false;
            // 
            // labOcupadas
            // 
            this.labOcupadas.AutoSize = true;
            this.labOcupadas.Location = new System.Drawing.Point(540, 52);
            this.labOcupadas.Name = "labOcupadas";
            this.labOcupadas.Size = new System.Drawing.Size(121, 13);
            this.labOcupadas.TabIndex = 5;
            this.labOcupadas.Text = "Habitaciones Ocupadas";
            // 
            // labLibres
            // 
            this.labLibres.AutoSize = true;
            this.labLibres.Location = new System.Drawing.Point(149, 52);
            this.labLibres.Name = "labLibres";
            this.labLibres.Size = new System.Drawing.Size(100, 13);
            this.labLibres.TabIndex = 4;
            this.labLibres.Text = "Habitaciones Libres";
            // 
            // btVisualizarHabi
            // 
            this.btVisualizarHabi.Location = new System.Drawing.Point(66, 308);
            this.btVisualizarHabi.Name = "btVisualizarHabi";
            this.btVisualizarHabi.Size = new System.Drawing.Size(75, 23);
            this.btVisualizarHabi.TabIndex = 8;
            this.btVisualizarHabi.Text = "Visualizar";
            this.btVisualizarHabi.UseVisualStyleBackColor = true;
            // 
            // gbHabiVis
            // 
            this.gbHabiVis.Location = new System.Drawing.Point(66, 356);
            this.gbHabiVis.Name = "gbHabiVis";
            this.gbHabiVis.Size = new System.Drawing.Size(681, 100);
            this.gbHabiVis.TabIndex = 9;
            this.gbHabiVis.TabStop = false;
            this.gbHabiVis.Text = "Habitacion";
            // 
            // conHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.gbHabiVis);
            this.Controls.Add(this.btVisualizarHabi);
            this.Controls.Add(this.listViewOcupadas);
            this.Controls.Add(this.listViewLibres);
            this.Controls.Add(this.labOcupadas);
            this.Controls.Add(this.labLibres);
            this.Name = "conHabitacion";
            this.Text = "Consultar Habitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOcupadas;
        private System.Windows.Forms.ListView listViewLibres;
        private System.Windows.Forms.Label labOcupadas;
        private System.Windows.Forms.Label labLibres;
        private System.Windows.Forms.Button btVisualizarHabi;
        private System.Windows.Forms.GroupBox gbHabiVis;
    }
}