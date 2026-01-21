namespace Phase06WorksitesNoSupplies.Services.Animals;
public class AnimalAutomatedCollectionPolicy : IAnimalCollectionPolicy
{
    Task<EnumAnimalCollectionMode> IAnimalCollectionPolicy.GetCollectionModeAsync()
    {
        return Task.FromResult(EnumAnimalCollectionMode.Automated);
    }
}