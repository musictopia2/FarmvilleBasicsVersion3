using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}