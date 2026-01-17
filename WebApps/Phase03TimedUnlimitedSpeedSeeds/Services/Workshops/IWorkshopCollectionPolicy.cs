namespace Phase03TimedUnlimitedSpeedSeeds.Services.Workshops;
public interface IWorkshopCollectionPolicy
{
    Task<bool> IsAutomaticAsync();
}