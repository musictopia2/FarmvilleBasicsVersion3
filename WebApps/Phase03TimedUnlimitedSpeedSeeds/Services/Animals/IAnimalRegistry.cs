namespace Phase03TimedUnlimitedSpeedSeeds.Services.Animals;
public interface IAnimalRegistry
{
    Task<BasicList<AnimalRecipe>> GetAnimalsAsync();
}