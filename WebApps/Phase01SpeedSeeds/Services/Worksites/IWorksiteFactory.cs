using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}