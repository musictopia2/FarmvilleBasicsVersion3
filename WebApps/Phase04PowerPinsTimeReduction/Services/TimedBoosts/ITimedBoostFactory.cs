namespace Phase04PowerPinsTimeReduction.Services.TimedBoosts;
public interface ITimedBoostFactory
{
    TimedBoostServicesContext GetTimedBoostServices(FarmKey farm);
}