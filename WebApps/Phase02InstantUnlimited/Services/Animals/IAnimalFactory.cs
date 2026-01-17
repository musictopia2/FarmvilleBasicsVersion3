using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}