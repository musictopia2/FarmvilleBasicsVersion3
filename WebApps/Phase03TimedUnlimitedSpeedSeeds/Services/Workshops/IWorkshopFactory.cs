using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Workshops;
public interface IWorkshopFactory
{
    WorkshopServicesContext GetWorkshopServices(FarmKey farm);
}