namespace Phase15PowerPinsTimeReduction.Models;
public class CatalogOfferModel
{
    public EnumCatalogCategory Category { get; init; }
    public string TargetName { get; init; } = "";
    public int LevelRequired { get; set; }
    public Dictionary<string, int> Costs { get; set; } = [];
    public bool Repeatable { get; set; } //so the store can reflect this.
    public TimeSpan? Duration { get; set; } //null means this will not expire.
}