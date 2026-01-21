using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}