namespace Phase05PowerPinsOutputAugmentation.Services.Trees;
public class TreeAutoResumeModel
{
    public string TreeName { get; set; } = "";
    public bool Unlocked { get; set; } = true;
    public int TreesReady { get; set; }
    public EnumTreeState State { get; set; } = EnumTreeState.Collecting;
    public DateTime? StartedAt { get; set; }
    public DateTime? TempStart { get; set; }
    public double? RunMultiplier { get; set; }
    public TimeSpan ReducedBy { get; set; } = TimeSpan.Zero;

    // Temporary override: something else is taking over the rule, so this tree shouldn't appear / be usable
    public bool IsSuppressed { get; set; } = false;

    public OutputAugmentationSnapshot? OutputPromise { get; set; }



    //good news is did not save time here so at least no problem here.

    // Production timing is determined by the associated TreeRecipe.
}