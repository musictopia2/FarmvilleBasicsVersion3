using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}