namespace Phase03TimedUnlimitedSpeedSeeds.Services.Crops;
public interface ICropRegistry
{
    Task<BasicList<CropRecipe>> GetCropsAsync();

}