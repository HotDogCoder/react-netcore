using time_of_your_life.Application.RepositoriesInterfaces;
using time_of_your_life.Application.ServicesInterfaces;
using time_of_your_life.Domain.Entities;

namespace time_of_your_life.Application.Services
{
    public class PresetService : PresetServiceInterface
    {
        private readonly PresetRepositoryInterface _presetRepository;

        public PresetService(PresetRepositoryInterface presetRepository)
        {
            _presetRepository = presetRepository;
        }

        public void CreatePreset(Preset preset)
        {
            _presetRepository.Create(preset);
        }

        public IEnumerable<Preset> GetPresets()
        {
           return _presetRepository.GetAll();
        }
    }
}
