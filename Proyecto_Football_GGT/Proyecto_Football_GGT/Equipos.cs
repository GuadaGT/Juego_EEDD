using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Football_GGT
{
    public partial class Equipos : Form
    {
        public Equipos()
        {
            InitializeComponent();
        }
        private void btncrearfichero_Click(object sender, EventArgs e)
        {
            // Creamos un objeto para cada uno de los equipos
            Equipo barbaros = new Equipo("Barbaros", 7);
            Equipo bardos = new Equipo("Bardos", 7);
            Equipo clerigos = new Equipo("Clerigos", 7);
            Equipo guerreros = new Equipo("Guerreros", 7);
            Equipo hechiceros = new Equipo("Hechiceros", 7);

            // Creamos un arreglo para guardar los equipos
            Equipo[] equipos = new Equipo[] { barbaros, bardos, clerigos, guerreros, hechiceros};
            // Obtenemos el nombre del archivo ingresado por el usuario
            string fileName = txtboxequipo.Text;

            // Verificamos si el nombre del archivo es válido
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    // Creamos el archivo con el nombre ingresado por el usuario y la extensión .txt
                    string path =  fileName + ".txt";
                    FileStream fileStream = File.Create(path);
                    fileStream.Close();

                    // Informamos al usuario que el archivo ha sido creado
                    MessageBox.Show("Enhorabuena! has creado el fichero del equipo!");

                    // Limpiamos el textbox
                    txtboxequipo.Text = "";
                }
                catch (Exception ex)
                {
                    // Informamos al usuario si se produce un error al crear el archivo
                    MessageBox.Show("Ha ocurrido un error al crear el archivo: " + ex.Message);
                }
            }
            else
            {
                // Informamos al usuario si no ha ingresado un nombre de archivo válido
                MessageBox.Show("Debe ingresar un nombre de archivo válido.");
            }
        }
    }
}
