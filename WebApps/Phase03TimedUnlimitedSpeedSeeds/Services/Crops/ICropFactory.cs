namespace Phase03TimedUnlimitedSpeedSeeds.Services.Crops;
public interface ICropFactory
{
    CropServicesContext GetCropServices(FarmKey farm);
}