namespace Phase08AutoCompleteSingle.Services.InstantUnlimited;
public interface IInstantUnlimitedFactory
{
    InstantUnlimitedServicesContext GetInstantUnlimitedServices(FarmKey farm);
}