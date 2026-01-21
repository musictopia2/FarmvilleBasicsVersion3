namespace Phase07PowerGloves.DataAccess.OutputAugmentation;
public class OutputAugmentationFactory : IOutputAugmentationFactory
{
    OutputAugmentationServicesContext IOutputAugmentationFactory.GetOutputAugmentationServices(FarmKey farm)
    {
        return new()
        {
            OutputAugmentationPlanProvider = new OutputAugmentationPlanDatabase()
        };
    }
}