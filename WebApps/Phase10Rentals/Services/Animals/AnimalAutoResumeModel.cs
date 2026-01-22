namespace Phase10Rentals.Services.Animals;
public class AnimalAutoResumeModel
{
    public string Name { get; set; } = "";
    public EnumAnimalState State { get; set; } = EnumAnimalState.None;
    public bool Unlocked { get; set; } = true;
    public bool IsSuppressed { get; set; } = false;
    public int ProductionOptionsAllowed { get; set; } = 1;
    public int OutputReady { get; set; }
    public double? RunMultiplier { get; set; }
    public TimeSpan ReducedBy { get; set; } = TimeSpan.Zero;
    
    public DateTime? StartedAt { get; set; }
    public int? Selected { get; set; }
    public bool ExtrasResolved { get; set; }
    public OutputAugmentationSnapshot? OutputPromise { get; set; }

    public BasicList<ItemAmount> ExtraRewards { get; set; } = []; //when you are about to collect, show then.

}