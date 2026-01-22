namespace Phase10Rentals.DataAccess.OutputAugmentation;
public class OutputAugmentationPlanDocument : IFarmDocument
{
    public FarmKey Farm { get; set; }
    public BasicList<OutputAugmentationPlanModel> Items { get; set; } = new();
}