namespace Phase11MVP3.Services.Crops;
public class CropAutomatedHarvestPolicy : ICropHarvestPolicy
{
    Task<bool> ICropHarvestPolicy.IsAutomaticAsync()
    {
        return Task.FromResult(true);
    }
}