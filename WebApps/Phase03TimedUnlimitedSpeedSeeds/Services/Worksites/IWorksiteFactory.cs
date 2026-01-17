using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}