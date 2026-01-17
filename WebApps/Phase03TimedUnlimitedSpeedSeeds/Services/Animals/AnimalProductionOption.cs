using Phase03TimedUnlimitedSpeedSeeds.Services.Inventory;

namespace Phase03TimedUnlimitedSpeedSeeds.Services.Animals;
public class AnimalProductionOption
{
    public ItemAmount Output { get; init; }
    public int Input { get; set; }
    public string Required { get; set; } = "";
    public TimeSpan Duration { get; init; }
}