namespace Phase03TimedUnlimitedSpeedSeeds.Services.Upgrades;
public interface IUpgradeFactory
{
    UpgradeServicesContext GetUpgradeServices(FarmKey farm);
}