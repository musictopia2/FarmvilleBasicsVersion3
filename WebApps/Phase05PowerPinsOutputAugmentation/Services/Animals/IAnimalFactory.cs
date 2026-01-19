using Phase05PowerPinsOutputAugmentation.Services.Core;

namespace Phase05PowerPinsOutputAugmentation.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}