using Phase10Rentals.Services.Core;

namespace Phase10Rentals.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}