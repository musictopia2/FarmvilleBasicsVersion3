using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.Trees;
public class TreeInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}