using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}