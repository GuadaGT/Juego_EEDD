namespace Proyecto_Football_GGT
{
    internal class Resultado
    {
        private string Equipo1;
        private string Equipo2;
        private int golesEquipo1;
        private int golesEquipo2;

        public Resultado(string Equipo1, string Equipo2, int golesEquipo1, int golesEquipo2)
        {
            this.Equipo1 = Equipo1;
            this.Equipo2 = Equipo2;
            this.golesEquipo1 = golesEquipo1;
            this.golesEquipo2 = golesEquipo2;
        }
    }
}