using Phase07PowerGloves.Services.Core;

namespace Phase07PowerGloves.DataAccess.Worksites;
public class WorksiteInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorksiteAutoResumeModel> Worksites { get; set; } = [];
}