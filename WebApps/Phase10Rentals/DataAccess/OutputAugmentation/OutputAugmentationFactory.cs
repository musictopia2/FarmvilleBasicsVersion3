namespace Phase10Rentals.DataAccess.OutputAugmentation;
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