using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}