using Phase11MVP3.Services.Core;

namespace Phase11MVP3.DataAccess.Worksites;
public class WorksiteInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorksiteAutoResumeModel> Worksites { get; set; } = [];
}