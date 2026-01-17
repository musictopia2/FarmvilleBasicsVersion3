namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface ILevelProgressionPlanProvider
{
    Task<LevelProgressionPlanModel> GetPlanAsync(FarmKey farm);
}