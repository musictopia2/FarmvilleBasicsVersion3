namespace Phase08AutoCompleteSingle.Services.TimedBoosts;
public interface ITimedBoostFactory
{
    TimedBoostServicesContext GetTimedBoostServices(FarmKey farm);
}