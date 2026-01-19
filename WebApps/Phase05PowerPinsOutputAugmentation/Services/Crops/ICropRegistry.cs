namespace Phase05PowerPinsOutputAugmentation.Services.Crops;
public interface ICropRegistry
{
    Task<BasicList<CropRecipe>> GetCropsAsync();

}