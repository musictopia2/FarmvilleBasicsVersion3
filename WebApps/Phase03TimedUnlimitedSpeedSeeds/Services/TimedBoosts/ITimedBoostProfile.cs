namespace Phase03TimedUnlimitedSpeedSeeds.Services.TimedBoosts;
public interface ITimedBoostProfile
{
    Task<TimedBoostProfileModel> LoadAsync();
    Task SaveAsync(TimedBoostProfileModel model);
}