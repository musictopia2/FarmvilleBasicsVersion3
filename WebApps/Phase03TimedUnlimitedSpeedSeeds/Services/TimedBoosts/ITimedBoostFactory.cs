namespace Phase03TimedUnlimitedSpeedSeeds.Services.TimedBoosts;
public interface ITimedBoostFactory
{
    TimedBoostServicesContext GetTimedBoostServices(FarmKey farm);
}