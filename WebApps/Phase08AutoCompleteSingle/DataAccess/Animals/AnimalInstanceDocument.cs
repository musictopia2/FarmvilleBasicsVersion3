using Phase08AutoCompleteSingle.Services.Core;

namespace Phase08AutoCompleteSingle.DataAccess.Animals;
public class AnimalInstanceDocument : IFarmDocument
{
    required public BasicList<AnimalAutoResumeModel> Animals { get; set; }
    required public FarmKey Farm { get; set; }
}