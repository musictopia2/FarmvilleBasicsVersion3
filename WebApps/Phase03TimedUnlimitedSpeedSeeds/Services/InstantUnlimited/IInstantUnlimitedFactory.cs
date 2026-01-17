namespace Phase03TimedUnlimitedSpeedSeeds.Services.InstantUnlimited;
public interface IInstantUnlimitedFactory
{
    InstantUnlimitedServicesContext GetInstantUnlimitedServices(FarmKey farm);
}