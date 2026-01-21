using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.DataAccess.Workshops;
public class WorkshopInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorkshopAutoResumeModel> Workshops { get; set; }
}