namespace Phase04PowerPinsTimeReduction.Services.TimedBoosts;
public interface ITimedBoostProfile
{
    Task<TimedBoostProfileModel> LoadAsync();
    Task SaveAsync(TimedBoostProfileModel model);
}