using Phase05PowerPinsOutputAugmentation.Services.Core;

namespace Phase05PowerPinsOutputAugmentation.DataAccess.Animals;
public class AnimalInstanceDocument : IFarmDocument
{
    required public BasicList<AnimalAutoResumeModel> Animals { get; set; }
    required public FarmKey Farm { get; set; }
}