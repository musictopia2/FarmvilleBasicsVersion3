namespace Phase15PowerPinsTimeReduction.Models;
public class AnimalAutoResumeModel
{
    public string Name { get; set; } = "";
    public EnumAnimalState State { get; set; } = EnumAnimalState.None;
    public bool Unlocked { get; set; } = true;
    public bool IsSuppressed { get; set; } = false;
    public int ProductionOptionsAllowed { get; set; } = 1;
    public int OutputReady { get; set; }
    public double? RunMultiplier { get; set; }
    //public TimeSpan? Duration { get; set; }
    public DateTime? StartedAt { get; set; }
    public int? Selected { get; set; }
    public TimeSpan ReducedBy { get; set; } = TimeSpan.Zero;
    //eventually needs to know about options you are allowed to do (later)
}