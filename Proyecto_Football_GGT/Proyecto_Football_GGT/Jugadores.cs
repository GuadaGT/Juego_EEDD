using System;
using System.Collections;
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
    public partial class Jugadores : Form
    {
        //LLamamos a las clases Equipos y Jugador en Arrays y listas para usarlos posteriormente.
        Equipo[] equipos = new Equipo[]
        {
          new Equipo("Barbaros"),
          new Equipo("Bardos"),
          new Equipo("Clerigos"),
          new Equipo("Guerreros"),
          new Equipo("Hechiceros")
        };
        List<Jugador> lista = new List<Jugador>();
        public Jugadores()
        {
            InitializeComponent();
        }
        private void btnanyadir_Click(object sender, EventArgs e)
        {
            // Obtenemos la información del jugador a través de lo que agrega el usuario a los TextBox
            string nombre = txtboxnombre.Text;
            string apellidos = txtboxapellidos.Text;
            string email = txtboxemail.Text;
            string telefono = txtboxtelefono.Text;
            // Verificamos si se han llenado todos los campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Debe llenar todos los campos para agregar un jugador.");
                return;
            }

            // Obtenemos el equipo seleccionado del ComboBox para agregar al nuevo jugador
            string nombreEquipo = cmbboxequipos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(nombreEquipo))
            {
                MessageBox.Show("Debe seleccionar un equipo para agregar un jugador.");
                return;
            }

            // Buscamos el equipo correspondiente al nombre seleccionado
            Equipo equipo = null;
            foreach (Equipo eq in equipos)
            {
                if (eq.Nombre_equipo == nombreEquipo)
                {
                    equipo = eq;
                    break;
                }
            }

            // Verificamos si se encontró el equipo
            if (equipo == null)
            {
                MessageBox.Show($"No se encontró el equipo {nombreEquipo}.");
                return;
            }
            // Creamos un nuevo jugador y lo agregamos al equipo correspondiente
            Jugador jugador = new Jugador(txtboxnombre.Text, txtboxapellidos.Text, txtboxemail.Text, txtboxtelefono.Text);
            equipo.agregarJugador(jugador);
            // Agregamos al jugador al archivo correspondiente de su equipo.
            string rutaArchivo = $"D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\{nombreEquipo}.txt";
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine("Nombre: "+ nombre+","+ "Apellidos: " + apellidos +","+ "Email: " + email + ","+ "Teléfono: " + telefono);
            }
            // Mostramos un mensaje de éxito al usuario
            MessageBox.Show($"Se ha agregado el jugador {nombre} {apellidos} al equipo {nombreEquipo}.");
            // Limpiamos toda la información de los TextBox
            txtboxnombre.Text = "";
            txtboxapellidos.Text = "";
            txtboxemail.Text = "";
            txtboxtelefono.Text = "";
        }
        private void btnconsultar_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre del equipo seleccionado en el ComboBox
            string nombreEquipo = cmbboxequipos.SelectedItem.ToString();

            // Creamos la ruta del archivo de texto correspondiente al equipo
            string rutaArchivo = $"D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\{nombreEquipo}.txt";

            // Abrimos el archivo de texto con el programa predeterminado del S.O
            Process.Start(rutaArchivo);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre del equipo seleccionado en el combobox
            string nombreEquipo = cmbboxequipos.SelectedItem.ToString();

            // Indicamos la ruta del archivo correspondiente al equipo
            string rutaArchivo = $"D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\{nombreEquipo}.txt";

            // Abrimos el archivo de texto con el programa predeterminado del S.O
            Process.Start(rutaArchivo);
            {
                // Mostramos un  mensaje al usuario para que modifique el campo que necesite modificar en el .txt y guarde posteriormente el archivo antes
                //de cerrarlo.
                MessageBox.Show($"El archivo de texto del equipo {nombreEquipo} se ha abierto correctamente. Modifique el jugador y guarde los cambios.");
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre del equipo seleccionado
            string nombreEquipo = cmbboxequipos.SelectedItem.ToString();

            // Construimos la ruta completa del archivo correspondiente al equipo
            string rutaArchivo = $"D:\\Proyecto_Football_GGT\\Proyecto_Football_GGT\\bin\\Debug\\{nombreEquipo}.txt";

            // Verificamos si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                // Si el archivo existe, lo eliminamos
                File.Delete(rutaArchivo);

                // Mostramos un mensaje al usuario informando que se ha eliminado el archivo
                MessageBox.Show($"El archivo del equipo {nombreEquipo} ha sido eliminado exitosamente.", "Archivo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si el archivo no existe, mostramos un mensaje al usuario informando que no se ha encontrado el archivo
                MessageBox.Show($"El archivo del equipo {nombreEquipo} no existe.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
