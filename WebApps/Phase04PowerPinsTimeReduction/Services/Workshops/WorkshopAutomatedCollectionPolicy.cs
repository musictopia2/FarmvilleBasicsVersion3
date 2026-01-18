namespace Phase04PowerPinsTimeReduction.Services.Workshops;
public class WorkshopAutomatedCollectionPolicy : IWorkshopCollectionPolicy
{
    Task<bool> IWorkshopCollectionPolicy.IsAutomaticAsync()
    {
        return Task.FromResult(true);
    }
}