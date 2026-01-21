using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}