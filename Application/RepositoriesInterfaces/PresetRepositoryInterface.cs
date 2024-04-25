using time_of_your_life.Domain.Entities;

namespace time_of_your_life.Application.RepositoriesInterfaces
{
    public interface PresetRepositoryInterface
    {
        IEnumerable<Preset> GetAll();

        Task Create(Preset preset);
    }
}
