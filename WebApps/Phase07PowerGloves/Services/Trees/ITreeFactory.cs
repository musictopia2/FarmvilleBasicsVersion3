using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}