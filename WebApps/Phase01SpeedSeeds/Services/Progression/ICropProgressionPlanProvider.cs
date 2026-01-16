namespace Phase01SpeedSeeds.Services.Progression;
public interface ICropProgressionPlanProvider
{
    Task<CropProgressionPlanModel> GetPlanAsync(FarmKey farm);
}