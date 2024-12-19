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
                    "Data Source = SQLEXPRESS;" + 
                    "Initial Catalog = FireBaseDB;" +
                    "Integrated Security = True;" +
                    "User Id = ;" +
                    "Password = ;" +
                    "Timeout = 600000;");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
