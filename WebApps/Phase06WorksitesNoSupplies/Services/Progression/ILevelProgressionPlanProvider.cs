namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface ILevelProgressionPlanProvider
{
    Task<LevelProgressionPlanModel> GetPlanAsync(FarmKey farm);
}