namespace Phase07PowerGloves.Services.OutputAugmentation;
public interface IOutputAugmentationPlanProvider
{
    Task<BasicList<OutputAugmentationPlanModel>> GetPlanAsync(FarmKey farm);
}