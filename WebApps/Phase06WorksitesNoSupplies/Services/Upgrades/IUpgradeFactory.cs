namespace Phase06WorksitesNoSupplies.Services.Upgrades;
public interface IUpgradeFactory
{
    UpgradeServicesContext GetUpgradeServices(FarmKey farm);
}