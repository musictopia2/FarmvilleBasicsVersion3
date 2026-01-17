using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.Worksites;
public class WorksiteInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorksiteAutoResumeModel> Worksites { get; set; } = [];
}