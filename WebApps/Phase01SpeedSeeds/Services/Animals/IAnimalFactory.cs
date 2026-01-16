using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}