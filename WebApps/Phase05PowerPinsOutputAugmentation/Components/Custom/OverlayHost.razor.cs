namespace Phase05PowerPinsOutputAugmentation.Components.Custom;

public partial class OverlayHost(OverlayService overlay, IToast toast) : IDisposable
{

    

    public void Dispose()
    {
        overlay.Changed -= Refresh;

        AnimalManager.OnAugmentedOutput -= OnAugmentedOutput;
        GC.SuppressFinalize(this);
    }
    private void Refresh()
    {
        InvokeAsync(StateHasChanged);
    }
    protected override void OnInitialized()
    {
        overlay.Changed += Refresh;

        AnimalManager.OnAugmentedOutput += OnAugmentedOutput;

        base.OnInitialized();
    }

    private void OnAugmentedOutput(ItemAmount obj)
    {
        toast.ShowSuccessToast($"You received {obj.Amount} of {obj.Item} from a power pin from harvesting/collecting");
    }
}