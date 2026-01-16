namespace Phase01SpeedSeeds.Services.Core;
public interface IStartFarmRegistry
{
    Task<BasicList<FarmKey>> GetFarmsAsync(); 
}