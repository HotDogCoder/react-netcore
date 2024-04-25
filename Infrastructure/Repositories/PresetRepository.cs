using time_of_your_life.Application.RepositoriesInterfaces;
using time_of_your_life.Domain.Entities;
using time_of_your_life.Infrastructure.Contexts;

namespace time_of_your_life.Infrastructure.Repositories
{
    public class PresetRepository : PresetRepositoryInterface
    {
        private readonly SqlLiteContext _context;

        public PresetRepository(SqlLiteContext context)
        {
            _context = context;
        }

        public Task Create(Preset preset)
        {
            _context.Presets.Add(preset);
            return _context.SaveChangesAsync();
        }

        public IEnumerable<Preset> GetAll()
        {
            return _context.Presets;
        }
    }
}
