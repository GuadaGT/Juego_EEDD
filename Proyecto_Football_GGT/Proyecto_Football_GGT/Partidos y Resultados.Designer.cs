namespace Proyecto_Football_GGT
{
    partial class Partidos_y_Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partidos_y_Resultados));
            this.txtboxvisitante = new System.Windows.Forms.TextBox();
            this.txtboxlocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxresultadovisitante = new System.Windows.Forms.TextBox();
            this.txtboxresultadolocal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnplanificarpartido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxvisitante
            // 
            this.txtboxvisitante.Location = new System.Drawing.Point(352, 60);
            this.txtboxvisitante.Name = "txtboxvisitante";
            this.txtboxvisitante.Size = new System.Drawing.Size(233, 20);
            this.txtboxvisitante.TabIndex = 9;
            // 
            // txtboxlocal
            // 
            this.txtboxlocal.Location = new System.Drawing.Point(31, 60);
            this.txtboxlocal.Name = "txtboxlocal";
            this.txtboxlocal.Size = new System.Drawing.Size(233, 20);
            this.txtboxlocal.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Equipo Visitante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Equipo Local:";
            // 
            // txtboxresultadovisitante
            // 
            this.txtboxresultadovisitante.Location = new System.Drawing.Point(352, 134);
            this.txtboxresultadovisitante.Name = "txtboxresultadovisitante";
            this.txtboxresultadovisitante.Size = new System.Drawing.Size(233, 20);
            this.txtboxresultadovisitante.TabIndex = 13;
            // 
            // txtboxresultadolocal
            // 
            this.txtboxresultadolocal.Location = new System.Drawing.Point(31, 134);
            this.txtboxresultadolocal.Name = "txtboxresultadolocal";
            this.txtboxresultadolocal.Size = new System.Drawing.Size(233, 20);
            this.txtboxresultadolocal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado:";
            // 
            // btnplanificarpartido
            // 
            this.btnplanificarpartido.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplanificarpartido.Location = new System.Drawing.Point(222, 181);
            this.btnplanificarpartido.Name = "btnplanificarpartido";
            this.btnplanificarpartido.Size = new System.Drawing.Size(169, 37);
            this.btnplanificarpartido.TabIndex = 15;
            this.btnplanificarpartido.Text = "Planificar partido";
            this.btnplanificarpartido.UseVisualStyleBackColor = true;
            this.btnplanificarpartido.Click += new System.EventHandler(this.btnplanificarpartido_Click);
            // 
            // Partidos_y_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(622, 250);
            this.Controls.Add(this.btnplanificarpartido);
            this.Controls.Add(this.txtboxresultadovisitante);
            this.Controls.Add(this.txtboxresultadolocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxvisitante);
            this.Controls.Add(this.txtboxlocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Partidos_y_Resultados";
            this.Text = "Partidos_y_Resultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxvisitante;
        private System.Windows.Forms.TextBox txtboxlocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxresultadovisitante;
        private System.Windows.Forms.TextBox txtboxresultadolocal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnplanificarpartido;
    }
}