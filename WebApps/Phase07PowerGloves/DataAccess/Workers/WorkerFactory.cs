using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.DataAccess.Workers;
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