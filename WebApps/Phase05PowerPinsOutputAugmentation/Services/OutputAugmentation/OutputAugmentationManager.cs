namespace Phase05PowerPinsOutputAugmentation.Services.OutputAugmentation;
public class OutputAugmentationManager
{
    BasicList<OutputAugmentationPlanModel> _plans = [];
    public async Task SetOutputAugmentationStyleContextAsync(OutputAugmentationServicesContext context, FarmKey farm)
    {
        _plans = await context.OutputAugmentationPlanProvider.GetPlanAsync(farm);
    }
    //should know when it needs to use this.
    public OutputAugmentationPlanModel GetPlanModel(string key)
    {
        var plan = _plans.SingleOrDefault(x => x.Key == key) ?? throw new CustomBasicException($"Could not find output augmentation plan with key {key}");
        return plan;
    }


    //not sure how the others will work yet.


}