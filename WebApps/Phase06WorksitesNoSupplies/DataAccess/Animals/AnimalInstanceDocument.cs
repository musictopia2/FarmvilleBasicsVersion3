using Phase06WorksitesNoSupplies.Services.Core;

namespace Phase06WorksitesNoSupplies.DataAccess.Animals;
public class AnimalInstanceDocument : IFarmDocument
{
    required public BasicList<AnimalAutoResumeModel> Animals { get; set; }
    required public FarmKey Farm { get; set; }
}