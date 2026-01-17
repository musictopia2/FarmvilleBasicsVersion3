namespace Phase02InstantUnlimited.Services.Items;
public class GrantableItem
{
    required public string Item { get; init; } = "";
    required public int Amount { get; init; }
    required public EnumItemCategory Category { get; init; }
}