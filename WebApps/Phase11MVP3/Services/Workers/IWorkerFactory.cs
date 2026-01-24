using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}