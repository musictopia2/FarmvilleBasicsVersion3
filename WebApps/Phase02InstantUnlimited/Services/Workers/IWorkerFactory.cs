using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}