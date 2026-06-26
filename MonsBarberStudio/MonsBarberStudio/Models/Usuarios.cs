using System.ComponentModel.DataAnnotations;

namespace MonsBarberStudio.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        public int IdRol { get; set; }
    }
}
