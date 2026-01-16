namespace Phase01SpeedSeeds.Services.Progression;
public interface IProgressionProfile
{
    Task<ProgressionProfileModel> LoadAsync();
    Task SaveAsync(ProgressionProfileModel profile);
}