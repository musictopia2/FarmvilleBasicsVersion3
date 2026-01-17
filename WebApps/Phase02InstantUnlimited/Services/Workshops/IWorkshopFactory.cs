using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}