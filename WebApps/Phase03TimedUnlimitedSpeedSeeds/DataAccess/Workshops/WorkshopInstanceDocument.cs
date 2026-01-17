using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.Workshops;
public class WorkshopInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorkshopAutoResumeModel> Workshops { get; set; }
}