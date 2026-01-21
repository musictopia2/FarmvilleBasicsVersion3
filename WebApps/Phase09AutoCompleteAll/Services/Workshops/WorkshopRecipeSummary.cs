using Phase09AutoCompleteAll.Services.Inventory;

namespace Phase09AutoCompleteAll.Services.Workshops;
public class WorkshopRecipeSummary
{
    public string Item { get; init; } = "";
    public Dictionary<string, int> Inputs { get; init; } = [];
    public ItemAmount Output { get; init; }
    public TimeSpan Duration { get; init; }
    public bool Unlocked { get; set; }
}