using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.DataAccess.Workers;
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