using Phase04PowerPinsTimeReduction.Services.Core;

namespace Phase04PowerPinsTimeReduction.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}