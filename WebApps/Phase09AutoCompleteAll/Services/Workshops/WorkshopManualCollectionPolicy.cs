namespace Phase09AutoCompleteAll.Services.Workshops;
public class WorkshopManualCollectionPolicy : IWorkshopCollectionPolicy
{
    Task<bool> IWorkshopCollectionPolicy.IsAutomaticAsync()
    {
        return Task.FromResult(false);
    }
}