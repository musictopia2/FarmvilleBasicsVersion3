namespace Phase04PowerPinsTimeReduction.Services.Crops;
public interface ICropFactory
{
    CropServicesContext GetCropServices(FarmKey farm);
}