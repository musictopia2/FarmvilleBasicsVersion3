using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}