namespace Phase01SpeedSeeds.Services.Progression;
public interface IProgressionFactory
{
    ProgressionServicesContext GetProgressionServices(FarmKey farm);
}