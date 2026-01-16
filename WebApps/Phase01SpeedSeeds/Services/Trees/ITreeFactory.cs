using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}