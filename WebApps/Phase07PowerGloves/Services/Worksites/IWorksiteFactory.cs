using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}