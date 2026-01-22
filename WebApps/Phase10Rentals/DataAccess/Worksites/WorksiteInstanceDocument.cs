using Phase10Rentals.Services.Core;

namespace Phase10Rentals.DataAccess.Worksites;
public class WorksiteInstanceDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<WorksiteAutoResumeModel> Worksites { get; set; } = [];
}