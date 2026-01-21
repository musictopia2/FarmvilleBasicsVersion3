namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface IProgressionFactory
{
    ProgressionServicesContext GetProgressionServices(FarmKey farm);
}