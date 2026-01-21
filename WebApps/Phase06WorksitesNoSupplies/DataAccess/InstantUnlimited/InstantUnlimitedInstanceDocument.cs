namespace Phase06WorksitesNoSupplies.DataAccess.InstantUnlimited;
public class InstantUnlimitedInstanceDocument : IFarmDocument
{
    public required FarmKey Farm { get; set; }
    public BasicList<UnlockModel> Items { get; set; } = [];
}