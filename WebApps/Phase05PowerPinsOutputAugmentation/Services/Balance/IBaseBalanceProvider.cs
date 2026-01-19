using Phase05PowerPinsOutputAugmentation.Services.Core;

namespace Phase05PowerPinsOutputAugmentation.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}