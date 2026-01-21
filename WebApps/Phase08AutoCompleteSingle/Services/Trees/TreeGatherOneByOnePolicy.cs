
namespace Phase08AutoCompleteSingle.Services.Trees;
public class TreeGatherOneByOnePolicy : ITreeGatheringPolicy
{
    Task<bool> ITreeGatheringPolicy.CollectAllAsync()
    {
        return Task.FromResult(false);
    }
}