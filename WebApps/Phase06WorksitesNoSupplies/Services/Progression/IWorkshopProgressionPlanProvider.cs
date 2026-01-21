namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface IWorkshopProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}