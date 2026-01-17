using Phase03TimedUnlimitedSpeedSeeds.Services.Core;

namespace Phase03TimedUnlimitedSpeedSeeds.DataAccess.Animals;
public class AnimalInstanceDocument : IFarmDocument
{
    required public BasicList<AnimalAutoResumeModel> Animals { get; set; }
    required public FarmKey Farm { get; set; }
}