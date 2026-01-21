namespace Phase06WorksitesNoSupplies.Services.Core;
public interface IStartFarmRegistry
{
    Task<BasicList<FarmKey>> GetFarmsAsync(); 
}