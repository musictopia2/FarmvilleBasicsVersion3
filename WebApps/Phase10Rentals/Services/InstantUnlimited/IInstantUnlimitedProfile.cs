namespace Phase10Rentals.Services.InstantUnlimited;
public interface IInstantUnlimitedProfile
{
    Task<BasicList<UnlockModel>> LoadAsync();
    Task SaveAsync(BasicList<UnlockModel> list);
}