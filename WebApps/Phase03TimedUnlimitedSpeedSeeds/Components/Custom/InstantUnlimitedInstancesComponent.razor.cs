namespace Phase03TimedUnlimitedSpeedSeeds.Components.Custom;
public partial class InstantUnlimitedInstancesComponent(IToast toast) : IDisposable
{

    private BasicList<string> _instances = [];

    private bool _openOptions = false;
    private string _currentOption = "";

    protected override void OnInitialized()
    {
        LoadList();
        Farm!.InstantUnlimitedManager.Changed += Refresh;
        base.OnInitialized();
    }
    private void LoadList()
    {
        _instances = Farm!.InstantUnlimitedManager.UnlockedInstances;
    }
    private void Refresh()
    {
        LoadList();
        InvokeAsync(StateHasChanged);
    }

    private static string GetName(string instance) => $"{instance}Unlimited";

    //i don't think this is quite a modal.

    private void ChooseInstance(string instance)
    {
        _currentOption = instance;
        _openOptions = true;
    }

    private void OnChose(int howMany)
    {
        if (Farm!.InstantUnlimitedManager.CanApplyInstantUnlimited(_currentOption, howMany) == false)
        {
            toast.ShowUserErrorToast("Unable to add to inventory.  Most likely out of barn or silo space");
            _openOptions = true;
            return;
        }
        Farm.InstantUnlimitedManager.ApplyInstantUnlimited(_currentOption, howMany);
        _currentOption = "";
        _openOptions = false;
    }

    public void Dispose()
    {
        Farm!.InstantUnlimitedManager.Changed -= Refresh;
        GC.SuppressFinalize(this);
    }
}