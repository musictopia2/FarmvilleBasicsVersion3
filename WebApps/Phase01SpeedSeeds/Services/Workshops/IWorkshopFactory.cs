using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}