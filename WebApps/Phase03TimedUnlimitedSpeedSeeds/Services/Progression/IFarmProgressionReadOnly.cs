namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface IFarmProgressionReadOnly
{
    int CurrentLevel { get; }
    bool CompletedGame { get; }
    event Action? Changed;
}