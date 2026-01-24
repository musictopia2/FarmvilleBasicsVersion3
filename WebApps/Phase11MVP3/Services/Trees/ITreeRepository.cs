namespace Phase11MVP3.Services.Trees;
public interface ITreeRepository
{
    Task<BasicList<TreeAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<TreeAutoResumeModel> list);
}