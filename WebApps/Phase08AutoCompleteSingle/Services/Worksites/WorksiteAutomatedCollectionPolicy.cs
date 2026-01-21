
namespace Phase08AutoCompleteSingle.Services.Worksites;
public class WorksiteAutomatedCollectionPolicy : IWorksiteCollectionPolicy
{
    Task<bool> IWorksiteCollectionPolicy.CollectAllAsync()
    {
        return Task.FromResult(true);
    }

}