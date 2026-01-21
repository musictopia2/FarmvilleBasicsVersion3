namespace Phase06WorksitesNoSupplies.Services.TimedBoosts;
public interface ITimedBoostProfile
{
    Task<TimedBoostProfileModel> LoadAsync();
    Task SaveAsync(TimedBoostProfileModel model);
}