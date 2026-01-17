using Phase02InstantUnlimited.Services.Core;

namespace Phase02InstantUnlimited.DataAccess.Trees;
public class TreeInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}