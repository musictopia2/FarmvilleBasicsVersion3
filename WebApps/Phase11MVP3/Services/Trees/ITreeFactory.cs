using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}