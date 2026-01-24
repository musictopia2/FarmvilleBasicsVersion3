namespace Phase11MVP3.Services.Upgrades;
public interface IWorkshopCapacityUpgradePlanProvider
{
    Task<BasicList<WorkshopCapacityUpgradePlanModel>> GetPlansAsync(FarmKey farm);
}