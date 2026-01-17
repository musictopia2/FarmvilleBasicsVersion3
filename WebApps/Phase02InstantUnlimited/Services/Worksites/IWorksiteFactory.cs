using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}