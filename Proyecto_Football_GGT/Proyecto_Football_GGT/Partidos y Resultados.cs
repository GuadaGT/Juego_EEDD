using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Proyecto_Football_GGT
{
    public partial class Partidos_y_Resultados : Form
    {
        public Partidos_y_Resultados()
        {
            InitializeComponent();
        }

        private void btnplanificarpartido_Click(object sender, EventArgs e)
        {
            //Instanciamos la clase Random para generar aleatoriamente los contrincantes y los goles marcados con un máximo de 4 goles por equipo
            Random rnd = new Random();
            string[] nombresEquipos = { "Barbaros", "Bardos", "Clerigos", "Guerreros", "Hechiceros" };
            string equipo1 = nombresEquipos[rnd.Next(0, 5)];
            string equipo2 = nombresEquipos[rnd.Next(0, 5)];

            while (equipo1 == equipo2)
            {
                equipo2 = nombresEquipos[rnd.Next(0, 5)];
            }

            int golesEquipo1 = rnd.Next(0, 5);
            int golesEquipo2 = rnd.Next(0, 5);

            txtboxlocal.Text = equipo1;
            txtboxvisitante.Text = equipo2;
            txtboxresultadolocal.Text = golesEquipo1.ToString();
            txtboxresultadovisitante.Text = golesEquipo2.ToString();

            string fileName = "Resultados";
            // Guardamos los resultados en un archivo de nueva creación llamado "resultados"
            string rutaResultados = fileName + ".txt";
            FileStream fileStream = File.Create(rutaResultados);
            using (StreamWriter sw = File.AppendText(rutaResultados))
            {
                sw.WriteLine($"{equipo1} {golesEquipo1} {golesEquipo2} {equipo2}");
            }
            // Mostramos al usuario un mensaje de alerta indicando que los resultados han sido guardados.
            MessageBox.Show("Resultados guardados correctamente.");
        }

    }
}
