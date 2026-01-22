using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Worksites;
public interface IWorksiteFactory
{
    WorksiteServicesContext GetWorksiteServices(FarmKey farm);
}