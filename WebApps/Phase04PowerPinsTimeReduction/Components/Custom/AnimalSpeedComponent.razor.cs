namespace Phase04PowerPinsTimeReduction.Components.Custom;

public partial class AnimalSpeedComponent(IToast toast)
{
    private BasicList<AnimalGrantModel> _animals = [];
    protected override void OnInitialized()
    {
        _animals = AnimalManager.GetUnlockedAnimalGrantItems();
        base.OnInitialized();
    }
    // how many of this animal type the player currently owns (unlocked instances)

    // Keep image naming consistent with AnimalChoiceModal
    private static string Normalize(string text)
        => text.Replace(" ", "").Replace("-", "").Replace("_", "").ToLowerInvariant();

    private static string GetItemImage(string itemName)
        => $"/{Normalize(itemName)}.png";

    private string DisplayAmount(AnimalGrantModel item) => $"+ {item.OutputData.Amount}";
    private void TryToUse(AnimalGrantModel item)
    {

        if (InventoryManager.Has(item.InputData.Item, item.InputData.Amount) == false)
        {
            toast.ShowUserErrorToast("You do not have the required ingredients");
            return;
        }




        if (InventoryManager.CanAdd(item.OutputData) == false)
        {
            toast.ShowUserErrorToast($"Barn is full.  Unable to add {item.OutputData.Item}");
            return;
        }
        if (InventoryManager.Has(CurrencyKeys.SpeedSeed, 1) == false)
        {
            toast.ShowUserErrorToast("You have no more speed seeds left");
            return;
        }

        AnimalManager.GrantAnimalItems(item, 1);

    }
}