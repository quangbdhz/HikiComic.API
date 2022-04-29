using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Comic.Data.EF
{
    public class ComicDbContextFactory : IDesignTimeDbContextFactory<ComicDbContext>
    {
        public ComicDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ComicDB");

            var optionsBuilder = new DbContextOptionsBuilder<ComicDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ComicDbContext(optionsBuilder.Options);
        }
    }
}
