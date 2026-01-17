using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}