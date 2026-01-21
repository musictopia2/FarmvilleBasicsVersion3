using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}