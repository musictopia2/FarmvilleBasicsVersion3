namespace Phase06WorksitesNoSupplies.Services.Crops;
public interface ICropFactory
{
    CropServicesContext GetCropServices(FarmKey farm);
}