using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}