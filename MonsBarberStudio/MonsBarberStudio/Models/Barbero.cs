namespace MonsBarberStudio.Models
{
    public class Barbero
    {
        public int IdBarbero { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
    }
}
