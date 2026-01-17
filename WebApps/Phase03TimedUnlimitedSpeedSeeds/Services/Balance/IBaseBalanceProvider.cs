using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}