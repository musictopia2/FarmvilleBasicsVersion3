namespace Phase03TimedUnlimitedSpeedSeeds.Services.Progression;
public interface IProgressionProfile
{
    Task<ProgressionProfileModel> LoadAsync();
    Task SaveAsync(ProgressionProfileModel profile);
}