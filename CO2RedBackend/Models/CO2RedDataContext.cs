using Microsoft.EntityFrameworkCore;

namespace CO2RedBackend.Models
{
    public class CO2RedDataContext :DbContext
    {

        public CO2RedDataContext(DbContextOptions options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CO2RedConnString");
            optionsBuilder.UseSqlServer(connectionString);
        }


        public DbSet<ElectricConsumption> ElectricConsumptions { get; set;}

        public DbSet<Plan>  Plans { get; set;}

        public DbSet<CO2Red> CO2Reds { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<GEFactor> GEFactors { get; set; }


    }
}
