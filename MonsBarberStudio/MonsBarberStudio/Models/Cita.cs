namespace MonsBarberStudio.Models
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public int IdBarbero { get; set; }
        public string NombreBarbero { get; set; }
        public int IdServicio { get; set; }
        public string NombreServicio { get; set; }
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
