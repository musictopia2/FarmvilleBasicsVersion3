namespace Phase03TimedUnlimitedSpeedSeeds.Services.Animals;
public interface IAnimalCollectionPolicy
{
    Task<EnumAnimalCollectionMode> GetCollectionModeAsync();
}