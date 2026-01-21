namespace Phase06WorksitesNoSupplies.Services.OutputAugmentation;
public interface IOutputAugmentationFactory
{
    OutputAugmentationServicesContext GetOutputAugmentationServices(FarmKey farm);
}