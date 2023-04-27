using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Football_GGT
{
    public partial class Ganadores : Form
    {
        public Ganadores()
        {
            InitializeComponent();
        }
        private void btnganadores_Click(object sender, EventArgs e)
        {
            // Ruta del archivo correspondiente al equipo
            string rutaResultados = $"D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\Resultados.txt";
            // Abrimos el archivo de texto con el programa predeterminado del S.O
            Process.Start(rutaResultados);
            MessageBox.Show("Resultados guardados en el archivo de resultados. Compruebelos y cierrelo. Gracias");
        }
    }
}            