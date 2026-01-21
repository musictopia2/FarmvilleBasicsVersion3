using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.DataAccess.Trees;
public class TreeInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}