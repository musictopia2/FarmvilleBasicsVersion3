namespace Phase05PowerPinsOutputAugmentation.Services.Crops;
public interface ICropFactory
{
    CropServicesContext GetCropServices(FarmKey farm);
}