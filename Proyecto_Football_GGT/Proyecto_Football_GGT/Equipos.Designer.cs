namespace Proyecto_Football_GGT
{
    partial class Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
            this.btncrearfichero = new System.Windows.Forms.Button();
            this.txtboxequipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncrearfichero
            // 
            this.btncrearfichero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearfichero.Location = new System.Drawing.Point(381, 19);
            this.btncrearfichero.Name = "btncrearfichero";
            this.btncrearfichero.Size = new System.Drawing.Size(118, 28);
            this.btncrearfichero.TabIndex = 19;
            this.btncrearfichero.Text = "Crear fichero";
            this.btncrearfichero.UseVisualStyleBackColor = true;
            this.btncrearfichero.Click += new System.EventHandler(this.btncrearfichero_Click);
            // 
            // txtboxequipo
            // 
            this.txtboxequipo.Location = new System.Drawing.Point(119, 21);
            this.txtboxequipo.Name = "txtboxequipo";
            this.txtboxequipo.Size = new System.Drawing.Size(233, 20);
            this.txtboxequipo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Equipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 152);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vamos a crear juntos los ficheros que guardarán \r\ntoda la información sobre los e" +
    "quipos.\r\nTe adjunto aquí el nombre de los mismos.\r\n1- Barbaros\r\n2- Bardos\r\n3- Cl" +
    "erigos\r\n4- Guerreros\r\n5- Hechiceros\r\n";
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(505, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncrearfichero);
            this.Controls.Add(this.txtboxequipo);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Equipos";
            this.Text = "Equipos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrearfichero;
        private System.Windows.Forms.TextBox txtboxequipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}