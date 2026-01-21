using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}