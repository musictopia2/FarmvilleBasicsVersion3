namespace Phase14TimedUnlimitedSpeedSeeds.Models;
public class InstantUnlimitedInstanceDocument : IFarmDocument
{
    public required FarmKey Farm { get; set; }
    public BasicList<UnlockModel> Items { get; set; } = [];
}