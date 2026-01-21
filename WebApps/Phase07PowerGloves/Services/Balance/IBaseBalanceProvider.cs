using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}