namespace Phase01SpeedSeeds.Services.Progression;
public interface IFarmProgressionReadOnly
{
    int CurrentLevel { get; }
    bool CompletedGame { get; }
    event Action? Changed;
}