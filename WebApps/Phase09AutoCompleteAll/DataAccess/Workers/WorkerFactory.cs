using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.DataAccess.Workers;
public class WorkerFactory : IWorkerFactory
{
    WorkerServicesContext IWorkerFactory.GetWorkerServices(FarmKey farm)
    {
        
        IWorkerRegistry register;
        register = new WorkerRecipeDatabase(farm);
        WorkerServicesContext output = new()
        {
            WorkerRegistry = register,
            WorkerRepository = new WorkerInstanceDatabase(farm)
        };
        return output;
    }
}