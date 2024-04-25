using time_of_your_life.Domain.Entities;

namespace time_of_your_life.Application.ServicesInterfaces
{
    public interface PresetServiceInterface
    {
        IEnumerable<Preset> GetPresets();
        void CreatePreset(Preset preset);
    }
}
