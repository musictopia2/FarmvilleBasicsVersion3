namespace Phase07PowerGloves.Services.Workshops;
public interface IWorkshopRespository
{
    Task<BasicList<WorkshopAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<WorkshopAutoResumeModel> workshops);
}