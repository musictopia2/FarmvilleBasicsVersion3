using Phase04PowerPinsTimeReduction.Services.Core;

namespace Phase04PowerPinsTimeReduction.DataAccess.Trees;
public class TreeInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}