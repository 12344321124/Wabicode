using System.ComponentModel.DataAnnotations;

namespace MonsBarberStudio.Models
{
    public class Roles
    {
        [Key]
        public int? IdRol { get; set; }
        public string? NombreRol { get; set; }
    }
}
