namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface IProgressionFactory
{
    ProgressionServicesContext GetProgressionServices(FarmKey farm);
}