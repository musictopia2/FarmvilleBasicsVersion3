using Phase09AutoCompleteAll.Services.Core;

namespace Phase09AutoCompleteAll.DataAccess.Animals;
public class AnimalInstanceDocument : IFarmDocument
{
    required public BasicList<AnimalAutoResumeModel> Animals { get; set; }
    required public FarmKey Farm { get; set; }
}