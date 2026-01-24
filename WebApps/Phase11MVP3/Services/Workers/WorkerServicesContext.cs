namespace Phase11MVP3.Services.Workers;
public class WorkerServicesContext
{
    required public IWorkerRegistry WorkerRegistry { get; init; }
    required public IWorkerRepository WorkerRepository { get; init; }
}