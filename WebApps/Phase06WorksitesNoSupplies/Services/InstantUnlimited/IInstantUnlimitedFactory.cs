namespace Phase06WorksitesNoSupplies.Services.InstantUnlimited;
public interface IInstantUnlimitedFactory
{
    InstantUnlimitedServicesContext GetInstantUnlimitedServices(FarmKey farm);
}