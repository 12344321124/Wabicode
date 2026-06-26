namespace MonsBarberStudio.Models
{
    public class DisponibilidadBarbero
    {
        public int IdDisponibilidad { get; set; }
        public int IdBarbero { get; set; }
        public string NombreBarbero { get; set; }
        public string DiaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
