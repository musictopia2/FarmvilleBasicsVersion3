namespace Phase06WorksitesNoSupplies.Services.Worksites;
public interface IWorksiteRepository
{
    Task<BasicList<WorksiteAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<WorksiteAutoResumeModel> worksites);
}