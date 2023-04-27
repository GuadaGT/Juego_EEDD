using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Football_GGT
{
    public class Equipo
    {
        private string nombre_equipo;
        private int numJugadores;
        private ArrayList jugadores;
        private int puntos;
        private int golesLocal;
        private int golesVisitante;


        public Equipo(string nombre_equipo)
        {
            this.nombre_equipo = nombre_equipo;
            this.numJugadores = 0;
            this.puntos = 0;
            this.golesLocal = 0;
            this.golesVisitante = 0;
            this.jugadores = new ArrayList();
        }
        public Equipo(string nombre_equipo, int numJugadores)
        {
            this.nombre_equipo = nombre_equipo;
            if (numJugadores <= 7)
            {
                this.numJugadores = numJugadores;
            }
            else
            {
                this.numJugadores = 7;
            }
        }

        public string Nombre_equipo
        {
            get { return nombre_equipo; }
            set { nombre_equipo = value; }
        }
        public int getPuntos()
        {
            return puntos;
        }

        public int getGolesLocal()
        {
            return golesLocal;
        }

        public int getGolesVisitante()
        {
            return golesVisitante;
        }

        public void setPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public void sumarGolesFavor(int cantidad)
        {
            this.golesLocal += cantidad;
        }

        public void sumarGolesContra(int cantidad)
        {
            this.golesVisitante += cantidad;
        }

        public int NumJugadores
        {
            get { return numJugadores; }
            set
            {
                if (value <= 7)
                {
                    numJugadores = value;
                }
                else
                {
                    numJugadores = 7;
                }
            }
        }
        public void agregarJugador(Jugador jugador)
        {
            if (this.numJugadores < 7)
            {
                this.jugadores.Add(jugador);
                this.numJugadores++;
            }
            else
            {
                throw new InvalidOperationException("El equipo ya tiene 7 jugadores.");
            }
        }

    }
}

