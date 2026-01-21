namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface IAnimalProgressionPlanProvider
{
    Task<BasicList<ItemUnlockRule>> GetPlanAsync(FarmKey farm);
}