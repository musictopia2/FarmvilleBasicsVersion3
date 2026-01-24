using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}