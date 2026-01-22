using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}