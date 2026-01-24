using Phase11MVP3.Services.Inventory;

namespace Phase11MVP3.Services.Workshops;
public class WorkshopRecipe
{
    public string BuildingName { get; init; } = "";
    public string Item { get; init; } = "";
    public Dictionary<string, int> Inputs { get; init; } = [];
    public ItemAmount Output { get; init; }
    public TimeSpan Duration { get; init; }
}