using Phase04PowerPinsTimeReduction.Services.Core;

namespace Phase04PowerPinsTimeReduction.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}