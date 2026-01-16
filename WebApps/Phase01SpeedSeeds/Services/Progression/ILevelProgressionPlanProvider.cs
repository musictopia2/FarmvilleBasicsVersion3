namespace Phase01SpeedSeeds.Services.Progression;
public interface ILevelProgressionPlanProvider
{
    Task<LevelProgressionPlanModel> GetPlanAsync(FarmKey farm);
}