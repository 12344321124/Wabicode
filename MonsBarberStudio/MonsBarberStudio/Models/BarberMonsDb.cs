

namespace MonsBarberStudio.Models
{
    public class BarberMonsDb
    {
        private readonly string _connectionString;

        public BarberMonsDb(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MonsBarberDB");
        }

    }
}