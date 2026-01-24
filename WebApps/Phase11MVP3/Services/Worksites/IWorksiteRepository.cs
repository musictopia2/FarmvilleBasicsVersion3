namespace Phase11MVP3.Services.Worksites;
public interface IWorksiteRepository
{
    Task<BasicList<WorksiteAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<WorksiteAutoResumeModel> worksites);
}