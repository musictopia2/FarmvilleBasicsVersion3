namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface ICropProgressionPlanProvider
{
    Task<CropProgressionPlanModel> GetPlanAsync(FarmKey farm);
}