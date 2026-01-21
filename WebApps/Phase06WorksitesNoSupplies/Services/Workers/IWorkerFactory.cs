using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}