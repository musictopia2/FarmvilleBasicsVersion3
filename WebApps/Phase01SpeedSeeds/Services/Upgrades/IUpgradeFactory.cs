namespace Phase01SpeedSeeds.Services.Upgrades;
public interface IUpgradeFactory
{
    UpgradeServicesContext GetUpgradeServices(FarmKey farm);
}