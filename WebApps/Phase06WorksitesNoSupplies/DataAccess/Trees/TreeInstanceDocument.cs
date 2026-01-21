using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.DataAccess.Trees;
public class TreeInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}