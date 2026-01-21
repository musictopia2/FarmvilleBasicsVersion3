using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}