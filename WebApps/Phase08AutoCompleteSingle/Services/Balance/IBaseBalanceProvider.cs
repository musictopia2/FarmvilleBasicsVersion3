using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}