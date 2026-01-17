using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}