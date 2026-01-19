using Phase05PowerPinsOutputAugmentation.Services.Core;

namespace Phase05PowerPinsOutputAugmentation.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}