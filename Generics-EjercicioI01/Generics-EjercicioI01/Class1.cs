namespace Generics_EjercicioI01
{
    public class Torneo<T> where T: Equipo
    {
        private List<T> equipos;
        private string nombre;

        public List<T> Equipos { get => equipos; set => equipos = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach(var equipoEnTorneo in torneo.equipos)
            {
                if (equipo == equipoEnTorneo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }
    }
}