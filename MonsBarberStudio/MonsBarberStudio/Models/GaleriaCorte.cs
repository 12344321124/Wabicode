namespace MonsBarberStudio.Models
{
    public class GaleriaCorte
    {
        public int IdCorte { get; set; }
        public string NombreCorte { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public decimal? PrecioReferencia { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
