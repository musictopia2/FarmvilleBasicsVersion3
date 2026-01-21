namespace Phase09AutoCompleteAll.Services.Worksites;
public interface IWorksiteRepository
{
    Task<BasicList<WorksiteAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<WorksiteAutoResumeModel> worksites);
}