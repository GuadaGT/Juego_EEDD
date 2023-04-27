using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Football_GGT
{
    public partial class Torneo_football : Form
    {
        public Torneo_football()
        {
            InitializeComponent();
            MessageBox.Show("Bienvenido a las jornadas de football inclusivas! \n Para poder organizarlas sigue las instrucciones que se te irán dando desde el principio." +
                "Es importante que comiences por la pestaña de 'Equipos' y tengas en cuenta que sólo podréis ser siete componentes como máximo en cada uno." +
                "Diviértete, sigue las normas y respeta a los compañeros." +
                "¡Que empiece el torneo!");
        }
        //Iniciamos el programa con un MessageBox que nos da las instrucciones a seguir y posteriormente instanciamos los formularios asociados a cada 
        // parte del menustrip
        private void eQUIPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipos ventana = new Equipos();
            ventana.MdiParent = this;
            ventana.Show();
        }
        private void jUGADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jugadores ventana = new Jugadores();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void pARTIDOSYRESULTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Partidos_y_Resultados ventana = new Partidos_y_Resultados();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void GanadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ganadores ventana = new Ganadores();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void ClasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clasificación ventana = new Clasificación();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
