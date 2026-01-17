namespace Phase03TimedUnlimitedSpeedSeeds.Components.Custom;

public partial class TimedBoostsComponent
{
    // Replace with your real source (manager/service/profile load)
    //public BasicList<TimedBoostCredit> Credits { get; set; } = new();

    private BasicList<TimedBoostCredit> _credits = [];

    protected override void OnInitialized()
    {
        Refresh();
        base.OnInitialized();
    }
    

    private void Refresh()
    {
        _credits = TimedBoostManager.GetBoosts();
    }

    private static string GetBoostImage(string boostKey)
        => $"/{boostKey}.png"; // if your files are /UnlimitedSpeedSeeds.png etc.

    private static string GetBoostTitle(string boostKey)
        => boostKey.GetWords;

    private async Task ActivateBoostAsync(TimedBoostCredit credit)
    {
        if (credit.Quantity <= 0)
        {
            return;
        }
        await TimedBoostManager.ActiveBoostAsync(credit);
        Refresh();
    }
}