using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}