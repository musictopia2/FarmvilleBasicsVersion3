namespace Phase11MVP3.Services.InstantUnlimited;
public interface IInstantUnlimitedProfile
{
    Task<BasicList<UnlockModel>> LoadAsync();
    Task SaveAsync(BasicList<UnlockModel> list);
}