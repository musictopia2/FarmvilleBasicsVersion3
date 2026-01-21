namespace Phase06WorksitesNoSupplies.Services.Workshops;
public interface IWorkshopRespository
{
    Task<BasicList<WorkshopAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<WorkshopAutoResumeModel> workshops);
}