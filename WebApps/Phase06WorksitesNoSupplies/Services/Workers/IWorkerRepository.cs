namespace Phase06WorksitesNoSupplies.Services.Workers;
public interface IWorkerRepository
{
    Task<BasicList<UnlockModel>> LoadAsync();
    Task SaveAsync(BasicList<UnlockModel> data);
}