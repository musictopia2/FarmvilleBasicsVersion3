using Phase01SpeedSeeds.Services.Core;

namespace Phase01SpeedSeeds.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}