using Phase05PowerPinsOutputAugmentation.Services.Core;

namespace Phase05PowerPinsOutputAugmentation.Services.Workers;
public interface IWorkerFactory
{
    WorkerServicesContext GetWorkerServices(FarmKey farm);
}