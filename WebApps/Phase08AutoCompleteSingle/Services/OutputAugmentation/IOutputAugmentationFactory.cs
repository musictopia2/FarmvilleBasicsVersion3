namespace Phase08AutoCompleteSingle.Services.OutputAugmentation;
public interface IOutputAugmentationFactory
{
    OutputAugmentationServicesContext GetOutputAugmentationServices(FarmKey farm);
}