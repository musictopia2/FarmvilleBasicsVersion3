using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}