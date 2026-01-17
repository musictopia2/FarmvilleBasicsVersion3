namespace Phase03TimedUnlimitedSpeedSeeds.Services.Workers;
public interface IWorkerRegistry
{
    Task<BasicList<WorkerRecipe>> GetWorkersAsync();
}