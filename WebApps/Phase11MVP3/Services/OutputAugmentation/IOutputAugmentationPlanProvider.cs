namespace Phase11MVP3.Services.OutputAugmentation;
public interface IOutputAugmentationPlanProvider
{
    Task<BasicList<OutputAugmentationPlanModel>> GetPlanAsync(FarmKey farm);
}