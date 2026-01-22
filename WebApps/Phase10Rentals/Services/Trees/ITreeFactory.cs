using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Trees;
public interface ITreeFactory
{
    TreeServicesContext GetTreeServices(FarmKey farm);
}