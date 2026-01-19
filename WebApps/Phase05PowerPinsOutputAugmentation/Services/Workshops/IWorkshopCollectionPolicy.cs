namespace Phase05PowerPinsOutputAugmentation.Services.Workshops;
public interface IWorkshopCollectionPolicy
{
    Task<bool> IsAutomaticAsync();
}