namespace Phase11MVP3.Services.Core;
public interface IGameTimer
{
    Task TickAsync();
    Task SetThemeContextAsync(FarmKey farm);
    MainFarmContainer FarmContainer { get; }
    FarmKey? FarmKey { get; }
}