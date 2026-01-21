using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}