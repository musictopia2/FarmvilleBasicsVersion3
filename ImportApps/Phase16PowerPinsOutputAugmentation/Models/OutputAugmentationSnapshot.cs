namespace Phase16PowerPinsOutputAugmentation.Models;
public class OutputAugmentationSnapshot
{
    public bool IsDouble { get; init; }
    public BasicList<string> ExtraRewards { get; init; } = [];
}