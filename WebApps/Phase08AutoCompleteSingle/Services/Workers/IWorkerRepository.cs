namespace Phase08AutoCompleteSingle.Services.Workers;
public interface IWorkerRepository
{
    Task<BasicList<UnlockModel>> LoadAsync();
    Task SaveAsync(BasicList<UnlockModel> data);
}