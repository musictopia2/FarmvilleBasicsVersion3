namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.InstantUnlimited;
public class InstantUnlimitedInstanceDocument : IFarmDocument
{
    public required FarmKey Farm { get; set; }
    public BasicList<UnlockModel> Items { get; set; } = [];
}