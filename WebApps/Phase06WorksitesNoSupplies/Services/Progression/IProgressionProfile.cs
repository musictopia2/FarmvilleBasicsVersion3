namespace Phase06WorksitesNoSupplies.Services.Progression;
public interface IProgressionProfile
{
    Task<ProgressionProfileModel> LoadAsync();
    Task SaveAsync(ProgressionProfileModel profile);
}