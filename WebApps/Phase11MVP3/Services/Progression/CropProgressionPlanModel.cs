namespace Phase11MVP3.Services.Progression;
public class CropProgressionPlanModel
{
    public BasicList<int> SlotLevelRequired { get; set; } = [];
    public BasicList<ItemUnlockRule> UnlockRules { get; set; } = [];
}