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

namespace Proyecto_Football_GGT
{
    public partial class Clasificación : Form
    {
       
        public Clasificación()
        {
            InitializeComponent();
        }

        private void btnclasificacion_Click(object sender, EventArgs e)
        {
            //Instanciamos las clases y listas que usaremos en este formulario.
            List<Partido> resultados = new List<Partido>();
            Equipo barbaros = new Equipo("Barbaros");
            Equipo bardos = new Equipo("Bardos");
            Equipo clerigos = new Equipo("Clerigos");
            Equipo guerreros = new Equipo("Guerreros");
            Equipo hechiceros = new Equipo("Hechiceros");
            List<Equipo> equipo = new List<Equipo> {barbaros,bardos,clerigos,guerreros,hechiceros };
            string pathResultados = "D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\resultados.txt";
            using (StreamReader sr = new StreamReader(pathResultados))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(' ');
                    Partido resultado = new Partido();
                    resultado.EquipoLocal = datos[0];
                    resultado.EquipoVisitante = datos[3];
                    resultado.GolesLocal = int.Parse(datos[1]);
                    resultado.GolesVisitante = int.Parse(datos[2]);
                    resultados.Add(resultado);
                }
            }
            // Creamos un diccionario para almacenar los puntos de cada equipo
            Dictionary<string, int> puntos = new Dictionary<string, int>();
            foreach (Equipo eq in equipo)
            {
                puntos.Add(eq.Nombre_equipo, 0);
            }

            // Calculamos los puntos de cada equipo a partir de los resultados de los partidos
            foreach (Partido resultado in resultados)
            {
                int golesLocal = resultado.GolesLocal;
                int golesVisitante = resultado.GolesVisitante;

                if (golesLocal > golesVisitante)
                {
                    puntos[resultado.EquipoLocal] += 3;
                }
                else if (golesLocal == golesVisitante)
                {
                    puntos[resultado.EquipoLocal] += 1;
                    puntos[resultado.EquipoVisitante] += 1;
                }
                else
                {
                    puntos[resultado.EquipoVisitante] += 3;
                }
            }
            // Guardamos los resultados en un archivo de nueva creación llamado "Clasificacion"
            string rutaClasificacion = @"D:\Proyecto_Football_GGT\Proyecto_Football_GGT\bin\Debug\\Clasificacion.txt";
            using (StreamWriter sw = File.AppendText(rutaClasificacion))
                foreach (Equipo eq in equipo)
                {
                   
                sw.WriteLine(eq.Nombre_equipo + ": " + puntos[eq.Nombre_equipo] + " puntos");
                }
            //Abrimos el .txt que contiene la clsificación por puntos.
            Process.Start(rutaClasificacion);
            //Mostramos los resultados finales en el MessageBox.
            string mensaje = "Clasificación:\n";
            foreach (Equipo eq in equipo)
            {
                mensaje += eq.Nombre_equipo + ": " + puntos[eq.Nombre_equipo] + " puntos\n";
            }
            MessageBox.Show(mensaje);
        }
    }
}
