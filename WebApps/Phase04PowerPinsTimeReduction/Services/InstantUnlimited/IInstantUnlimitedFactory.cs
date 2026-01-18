namespace Phase04PowerPinsTimeReduction.Services.InstantUnlimited;
public interface IInstantUnlimitedFactory
{
    InstantUnlimitedServicesContext GetInstantUnlimitedServices(FarmKey farm);
}