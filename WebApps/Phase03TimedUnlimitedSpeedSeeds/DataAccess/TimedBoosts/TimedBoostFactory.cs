namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.TimedBoosts;
public class TimedBoostFactory : ITimedBoostFactory
{
    TimedBoostServicesContext ITimedBoostFactory.GetTimedBoostServices(FarmKey farm)
    {
        return new()
        {
            TimedBoostProfile = new TimedBoostProfileDatabase(farm)
        };
    }
}