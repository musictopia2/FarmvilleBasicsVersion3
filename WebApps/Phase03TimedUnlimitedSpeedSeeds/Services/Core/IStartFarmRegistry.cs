namespace Phase03TimedUnlimitedSpeedSeeds.Services.Core;
public interface IStartFarmRegistry
{
    Task<BasicList<FarmKey>> GetFarmsAsync(); 
}