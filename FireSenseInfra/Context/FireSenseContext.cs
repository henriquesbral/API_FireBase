using FireSense.WebApi.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace FireSenseInfra.Context
{
    public class FireSenseContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            try
            {
                optionsBuilder.UseSqlServer(
                    "Data Source = LENOVOHENRIQUE\\SQLEXPRESS;" + 
                    "Initial Catalog = FireBaseDB;" +
                    "Integrated Security = True;" +
                    "User Id = aps2024;" +
                    "Password = 140612;" +
                    "Timeout = 600000;");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
