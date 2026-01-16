using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}