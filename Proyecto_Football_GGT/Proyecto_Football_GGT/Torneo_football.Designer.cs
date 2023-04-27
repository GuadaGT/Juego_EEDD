namespace Proyecto_Football_GGT
{
    partial class Torneo_football
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Torneo_football));
            this.MenuSFootball = new System.Windows.Forms.MenuStrip();
            this.eQUIPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jUGADORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARTIDOSYRESULTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GanadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSFootball.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSFootball
            // 
            this.MenuSFootball.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuSFootball.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eQUIPOSToolStripMenuItem,
            this.pARTIDOSYRESULTADOSToolStripMenuItem,
            this.GanadoresToolStripMenuItem,
            this.ClasificaciónToolStripMenuItem});
            this.MenuSFootball.Location = new System.Drawing.Point(0, 0);
            this.MenuSFootball.Name = "MenuSFootball";
            this.MenuSFootball.Size = new System.Drawing.Size(800, 24);
            this.MenuSFootball.TabIndex = 0;
            this.MenuSFootball.Text = "menuStrip1";
            // 
            // eQUIPOSToolStripMenuItem
            // 
            this.eQUIPOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jUGADORESToolStripMenuItem});
            this.eQUIPOSToolStripMenuItem.Name = "eQUIPOSToolStripMenuItem";
            this.eQUIPOSToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.eQUIPOSToolStripMenuItem.Text = "EQUIPOS";
            this.eQUIPOSToolStripMenuItem.Click += new System.EventHandler(this.eQUIPOSToolStripMenuItem_Click);
            // 
            // jUGADORESToolStripMenuItem
            // 
            this.jUGADORESToolStripMenuItem.Name = "jUGADORESToolStripMenuItem";
            this.jUGADORESToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.jUGADORESToolStripMenuItem.Text = "JUGADORES";
            this.jUGADORESToolStripMenuItem.Click += new System.EventHandler(this.jUGADORESToolStripMenuItem_Click);
            // 
            // pARTIDOSYRESULTADOSToolStripMenuItem
            // 
            this.pARTIDOSYRESULTADOSToolStripMenuItem.Name = "pARTIDOSYRESULTADOSToolStripMenuItem";
            this.pARTIDOSYRESULTADOSToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.pARTIDOSYRESULTADOSToolStripMenuItem.Text = "PARTIDOS Y RESULTADOS";
            this.pARTIDOSYRESULTADOSToolStripMenuItem.Click += new System.EventHandler(this.pARTIDOSYRESULTADOSToolStripMenuItem_Click);
            // 
            // GanadoresToolStripMenuItem
            // 
            this.GanadoresToolStripMenuItem.Name = "GanadoresToolStripMenuItem";
            this.GanadoresToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.GanadoresToolStripMenuItem.Text = "GANADORES";
            this.GanadoresToolStripMenuItem.Click += new System.EventHandler(this.GanadoresToolStripMenuItem_Click);
            // 
            // ClasificaciónToolStripMenuItem
            // 
            this.ClasificaciónToolStripMenuItem.Name = "ClasificaciónToolStripMenuItem";
            this.ClasificaciónToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.ClasificaciónToolStripMenuItem.Text = "CLASIFICACIÓN";
            this.ClasificaciónToolStripMenuItem.Click += new System.EventHandler(this.ClasificaciónToolStripMenuItem_Click);
            // 
            // Torneo_football
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Football_GGT.Properties.Resources.legend_of_vox_machina_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuSFootball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuSFootball;
            this.Name = "Torneo_football";
            this.Text = "TORNEO DE FOOTBALL";
            this.MenuSFootball.ResumeLayout(false);
            this.MenuSFootball.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSFootball;
        private System.Windows.Forms.ToolStripMenuItem eQUIPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jUGADORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARTIDOSYRESULTADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GanadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClasificaciónToolStripMenuItem;
    }
}

