namespace Phase13SpeedSeeds.Models;
public class TreeInstanceDocument
{
    required public FarmKey Farm { get; set; }
    required public BasicList<TreeAutoResumeModel> Trees { get; set; }
}