namespace Phase06WorksitesNoSupplies.Services.Upgrades;
public interface IWorkshopCapacityUpgradePlanProvider
{
    Task<BasicList<WorkshopCapacityUpgradePlanModel>> GetPlansAsync(FarmKey farm);
}