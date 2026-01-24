using Phase11MVP3.Services.Core;

namespace Phase11MVP3.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}