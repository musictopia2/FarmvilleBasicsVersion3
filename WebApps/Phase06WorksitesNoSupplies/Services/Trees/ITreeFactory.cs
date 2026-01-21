using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}