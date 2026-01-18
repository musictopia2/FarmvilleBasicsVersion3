using Phase04PowerPinsTimeReduction.Services.Core;

namespace Phase04PowerPinsTimeReduction.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}