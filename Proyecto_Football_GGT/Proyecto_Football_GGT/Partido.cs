using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Football_GGT
{
    public class Partido
    {
        private string equipoLocal;
        private int numerojugadoresLocal;
        private int golesLocal;
        private string equipoVisitante;
        private int numerojugadoresVisitante;
        private int golesVisitante;


        public Partido()
        {
        }
        public Partido(string equipoLocal = null, int numerojugadoresLocal = 0, int golesLocal = 0, string equipoVisitante = null, int numerojugadoresVisitante = 0, int golesVisitante = 0)
        {
            this.equipoLocal = equipoLocal;
            this.numerojugadoresLocal = numerojugadoresLocal;
            this.golesLocal = golesLocal;
            this.equipoVisitante = equipoVisitante;
            this.numerojugadoresVisitante = numerojugadoresVisitante;
            this.golesVisitante = golesVisitante;
        }
        public string EquipoLocal
        {
            get => equipoLocal;
            set => equipoLocal = value;
        }
        public int NumerojugadoresLocal
        {
            get => numerojugadoresLocal;
            set => numerojugadoresLocal = value;
        }
        public int GolesLocal
        {
            get => golesLocal; 
            set => golesLocal = value;
        }
        public string EquipoVisitante
        {
            get => equipoVisitante;
            set => equipoVisitante = value;
        }
        public int NumerojugadoresVisitante
        {
            get => numerojugadoresVisitante;
            set => numerojugadoresVisitante = value;
        }
        public int GolesVisitante
        {
            get => golesVisitante;
            set => golesVisitante = value;
        }
    }
}
