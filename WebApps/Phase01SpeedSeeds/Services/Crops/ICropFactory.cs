namespace Phase01SpeedSeeds.Services.Crops;
public interface ICropFactory
{
    CropServicesContext GetCropServices(FarmKey farm);
}