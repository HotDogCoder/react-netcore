using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using time_of_your_life.Infrastructure.Contexts;

namespace time_of_your_life.Infrastructure.Factories
{
    public class SqlLiteContextFactory : IDesignTimeDbContextFactory<SqlLiteContext>
    {
        public SqlLiteContext CreateDbContext(string[] args)
        {
            var directory = Path.Combine(Directory.GetCurrentDirectory());

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(directory)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<SqlLiteContext>();
            optionsBuilder.UseSqlite(connectionString);

            return new SqlLiteContext(optionsBuilder.Options);
        }

    }
}
