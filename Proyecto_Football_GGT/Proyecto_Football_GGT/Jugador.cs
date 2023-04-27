using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Football_GGT
{
    public class Jugador
    {
        private string nombre { get; set; }
        private string apellidos { get; set; }
        private string email { get; set; }
        private string telefono { get; set; }

        public Jugador()
        {
        }
        public Jugador(string nombre, string apellidos, string email, string telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
        }
    }
}
