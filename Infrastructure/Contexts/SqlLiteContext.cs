using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using time_of_your_life.Domain.Entities;
using time_of_your_life.Infrastructure.Configurations;

namespace time_of_your_life.Infrastructure.Contexts
{
    public class SqlLiteContext : DbContext
    {
        public SqlLiteContext(DbContextOptions<SqlLiteContext> options) : base(options) { }

        // DbSet properties for your entities go here, e.g.:
        public DbSet<Preset> Presets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PresetConfiguration());
        }
    }
}
