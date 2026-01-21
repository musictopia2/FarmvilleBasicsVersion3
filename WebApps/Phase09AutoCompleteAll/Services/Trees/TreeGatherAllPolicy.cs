
namespace Phase09AutoCompleteAll.Services.Trees;
public class TreeGatherAllPolicy : ITreeGatheringPolicy
{
    Task<bool> ITreeGatheringPolicy.CollectAllAsync()
    {
        return Task.FromResult(true);
    }
}