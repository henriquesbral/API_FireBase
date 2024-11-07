using FireSense.Domain.FireSenseContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FireSense.Context.Context
{
    public class FireSenseConnection : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Cidade> Cidade { get; set; }

        public DbSet<Estado> Estado { get; set; }

        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }

        public FireSenseConnection(IConfiguration configuration, DbContextOptions options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                var dataBase = _configuration["FireSenseConnection"];
                var connectionString = _configuration.GetConnectionString(dataBase);

                if (connectionString != null)
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }
}
