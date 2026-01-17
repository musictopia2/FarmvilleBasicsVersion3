using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}