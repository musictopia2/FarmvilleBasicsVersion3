namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface ICropProgressionPlanProvider
{
    Task<CropProgressionPlanModel> GetPlanAsync(FarmKey farm);
}