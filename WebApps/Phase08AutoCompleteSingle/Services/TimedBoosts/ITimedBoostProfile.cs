namespace Phase08AutoCompleteSingle.Services.TimedBoosts;
public interface ITimedBoostProfile
{
    Task<TimedBoostProfileModel> LoadAsync();
    Task SaveAsync(TimedBoostProfileModel model);
}