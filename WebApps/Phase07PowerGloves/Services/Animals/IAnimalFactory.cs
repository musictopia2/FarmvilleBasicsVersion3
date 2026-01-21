using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Animals;
public interface IAnimalFactory
{
    AnimalServicesContext GetAnimalServices(FarmKey farm);
}