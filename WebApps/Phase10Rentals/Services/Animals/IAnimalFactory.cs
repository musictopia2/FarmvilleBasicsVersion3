using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}