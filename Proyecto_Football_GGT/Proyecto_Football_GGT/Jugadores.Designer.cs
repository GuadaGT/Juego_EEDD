namespace Proyecto_Football_GGT
{
    partial class Jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugadores));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxnombre = new System.Windows.Forms.TextBox();
            this.txtboxapellidos = new System.Windows.Forms.TextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxtelefono = new System.Windows.Forms.TextBox();
            this.btnanyadir = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.cmbboxequipos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teléfono:";
            // 
            // txtboxnombre
            // 
            this.txtboxnombre.Location = new System.Drawing.Point(130, 38);
            this.txtboxnombre.Name = "txtboxnombre";
            this.txtboxnombre.Size = new System.Drawing.Size(233, 20);
            this.txtboxnombre.TabIndex = 4;
            // 
            // txtboxapellidos
            // 
            this.txtboxapellidos.Location = new System.Drawing.Point(130, 89);
            this.txtboxapellidos.Name = "txtboxapellidos";
            this.txtboxapellidos.Size = new System.Drawing.Size(233, 20);
            this.txtboxapellidos.TabIndex = 5;
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(130, 140);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(233, 20);
            this.txtboxemail.TabIndex = 6;
            // 
            // txtboxtelefono
            // 
            this.txtboxtelefono.Location = new System.Drawing.Point(130, 188);
            this.txtboxtelefono.Name = "txtboxtelefono";
            this.txtboxtelefono.Size = new System.Drawing.Size(233, 20);
            this.txtboxtelefono.TabIndex = 7;
            // 
            // btnanyadir
            // 
            this.btnanyadir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanyadir.Location = new System.Drawing.Point(380, 30);
            this.btnanyadir.Name = "btnanyadir";
            this.btnanyadir.Size = new System.Drawing.Size(118, 28);
            this.btnanyadir.TabIndex = 8;
            this.btnanyadir.Text = "Añadir ";
            this.btnanyadir.UseVisualStyleBackColor = true;
            this.btnanyadir.Click += new System.EventHandler(this.btnanyadir_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar.Location = new System.Drawing.Point(380, 80);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(118, 28);
            this.btnconsultar.TabIndex = 11;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(380, 129);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(118, 28);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(380, 180);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(118, 28);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // cmbboxequipos
            // 
            this.cmbboxequipos.FormattingEnabled = true;
            this.cmbboxequipos.Items.AddRange(new object[] {
            "Barbaros",
            "Bardos",
            "Clerigos",
            "Guerreros",
            "Hechiceros"});
            this.cmbboxequipos.Location = new System.Drawing.Point(130, 231);
            this.cmbboxequipos.Name = "cmbboxequipos";
            this.cmbboxequipos.Size = new System.Drawing.Size(121, 21);
            this.cmbboxequipos.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Equipo:";
            // 
            // Jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(567, 264);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbboxequipos);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnanyadir);
            this.Controls.Add(this.txtboxtelefono);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.txtboxapellidos);
            this.Controls.Add(this.txtboxnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Jugadores";
            this.Text = "Jugadores";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxnombre;
        private System.Windows.Forms.TextBox txtboxapellidos;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxtelefono;
        private System.Windows.Forms.Button btnanyadir;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.ComboBox cmbboxequipos;
        private System.Windows.Forms.Label label5;
    }
}