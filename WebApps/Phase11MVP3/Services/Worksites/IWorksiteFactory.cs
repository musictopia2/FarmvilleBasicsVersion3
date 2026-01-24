using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}