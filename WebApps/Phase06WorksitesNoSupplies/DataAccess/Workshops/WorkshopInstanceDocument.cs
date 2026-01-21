using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.DataAccess.Workshops;
public class WorkshopInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorkshopAutoResumeModel> Workshops { get; set; }
}