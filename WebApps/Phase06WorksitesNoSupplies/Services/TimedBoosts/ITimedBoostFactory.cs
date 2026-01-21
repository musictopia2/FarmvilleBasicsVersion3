namespace Phase06WorksitesNoSupplies.Services.TimedBoosts;
public interface ITimedBoostFactory
{
    TimedBoostServicesContext GetTimedBoostServices(FarmKey farm);
}