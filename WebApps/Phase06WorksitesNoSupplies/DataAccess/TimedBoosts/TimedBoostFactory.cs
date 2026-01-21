namespace Phase06WorksitesNoSupplies.DataAccess.TimedBoosts;
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