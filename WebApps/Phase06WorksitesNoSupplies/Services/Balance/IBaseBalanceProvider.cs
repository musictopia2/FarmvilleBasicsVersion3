using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.Services.Balance;
public interface IBaseBalanceProvider
{
    Task<BaseBalanceProfile> GetBaseBalanceAsync(FarmKey farm);
}