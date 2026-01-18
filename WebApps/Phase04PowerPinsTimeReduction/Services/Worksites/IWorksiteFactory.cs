using Phase04PowerPinsTimeReduction.Services.Core;

namespace Phase04PowerPinsTimeReduction.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}