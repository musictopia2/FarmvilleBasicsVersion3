using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}