namespace Phase16PowerPinsOutputAugmentation.Models;
public class OutputAugmentationPlanDocument : IFarmDocument
{
    public FarmKey Farm { get; set; }
    public BasicList<OutputAugmentationPlanModel> Items { get; set; } = new();
}