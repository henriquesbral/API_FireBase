using FireSense.WebApi.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FireSenseInfra.Context
{
    public class FireSenseContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlServer("Server=LENOVOHENRIQUE\\SQLEXPRESS; Database=FireSenseDB; User=aps2024; Password=140612; Trusted_Connection=False; TrustServerCertificate=true");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
