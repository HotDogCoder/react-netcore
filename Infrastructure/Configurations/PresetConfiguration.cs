using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using time_of_your_life.Domain.Entities;

namespace time_of_your_life.Infrastructure.Configurations
{
    public class PresetConfiguration : IEntityTypeConfiguration<Preset>
    {
        public void Configure(EntityTypeBuilder<Preset> builder)
        {
            builder.HasKey(q => q.Id);
        }
    }
}
