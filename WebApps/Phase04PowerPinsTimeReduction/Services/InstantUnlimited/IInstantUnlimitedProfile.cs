namespace Phase04PowerPinsTimeReduction.Services.InstantUnlimited;
public interface IInstantUnlimitedProfile
{
    Task<BasicList<UnlockModel>> LoadAsync();
    Task SaveAsync(BasicList<UnlockModel> list);
}