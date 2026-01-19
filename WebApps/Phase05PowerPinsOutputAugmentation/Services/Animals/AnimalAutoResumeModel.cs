namespace Phase05PowerPinsOutputAugmentation.Services.Animals;
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

    //cannot do duraton in the autoresume model anymore.

    //public TimeSpan? Duration { get; set; }
    public DateTime? StartedAt { get; set; }
    public int? Selected { get; set; }
    //eventually needs to know about options you are allowed to do (later)
}