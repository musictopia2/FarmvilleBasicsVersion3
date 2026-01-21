using BasicBlazorLibrary.Components.Layouts;
using BasicBlazorLibrary.Components.NavigationMenus;
using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.Components.Custom;
public partial class MainComponent(NavigationManager nav, OverlayService service,
    IToast toast, IntegerPickerService quantityPickerService,
    IntegerActionPickerService actionPickerService
    ) : IDisposable
{

    [Parameter]
    public string Theme { get; set; } = string.Empty;

    [Parameter]
    public string Player { get; set; } = string.Empty;

    [Parameter]
    public string ProfileId { get; set; } = string.Empty;

    private NavigationBarContainer? _nav;

    private readonly OverlayInsets _overlays = new();
    
    private void VisibleChanged(bool visible)
    {
        quantityPickerService.UpdateVisibleStatus(visible);
    }
    private bool HasAnyActiveTimedBoosts => TimedBoostManager.GetActiveBoosts.Count > 0;
    private async Task OnValueChanged(int value)
    {
        quantityPickerService.Submit(value);

        await Task.CompletedTask;
    }

    private void ShowActiveBoosts()
    {
        _showActiveBoosts = true;
    }

    private void Changed()
    {
        InvokeAsync(StateHasChanged);
    }
    protected override void OnAfterRender(bool firstRender)
    {
        if (_nav is not null)
        {
            _overlays.TopPx = _nav.HeightOfHeader + 5;
            _overlays.BottomPx = 10;
            StateHasChanged();
            return;
        }
        base.OnAfterRender(firstRender);
    }
    protected override void OnInitialized()
    {
        quantityPickerService.StateChanged = Changed;
        TimedBoostManager.Tick += Changed;
        service.Toast = toast;
        base.OnInitialized();
    }
    protected override async Task OnInitializedAsync()
    {
        await service.CloseAllAsync();
        await base.OnInitializedAsync();
    }
    private void ChooseAnotherTheme()
    {
        service.Reset();
        nav.NavigateTo("/");
    }
    private bool _showBarn = false;
    private bool _showSilo = false;
    private bool _showShop = false;
    private bool _showSpeedSeeds = false;
    private bool _showTimedBoosts = false;
    private bool _showActiveBoosts = false;

    private async Task CloseAllPopupsAsync()
    {
        await service.CloseAllAsync();
    }
    private void ShowTimedBoosts()
    {
        _showTimedBoosts = true;
    }
    private void ShowSpeedSeeds()
    {
        _showSpeedSeeds = true;
    }
    private void ShowShop()
    {
        _showShop = true;
    }
    private void ShowSilo()
    {
        _showSilo = true;
    }
    
    private void ShowBarn()
    {
        _showBarn = true;
    }
    private void CloseBarn()
    {
        _showBarn = false;
    }

    public void Dispose()
    {
        quantityPickerService.StateChanged = null;
        GC.SuppressFinalize(this);
    }

    private string Title
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Theme))
            {
                return "Needs Theme";
            }
            return $"{Player.ToDisplayPlayerName()} {Theme.GetWords} {ProfileId.GetWords}";
        }
    }

    private void ActionVisibleChanged(bool visible)
    {
        actionPickerService.UpdateVisibleStatus(visible);
    }

    private async Task OnActionValueChanged(int value)
    {
        await actionPickerService.SubmitAsync(value);
    }

}