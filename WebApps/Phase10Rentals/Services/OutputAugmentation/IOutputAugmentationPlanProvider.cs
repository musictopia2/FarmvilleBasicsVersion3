namespace Phase10Rentals.Services.OutputAugmentation;
public interface IOutputAugmentationPlanProvider
{
    Task<BasicList<OutputAugmentationPlanModel>> GetPlanAsync(FarmKey farm);
}