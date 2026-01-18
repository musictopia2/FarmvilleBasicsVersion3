namespace Phase04PowerPinsTimeReduction.Components.Custom;
public partial class BoostIconComponent
{
    [Parameter, EditorRequired]
    public string Name { get; set; } = ""; // base image key

    [Parameter]
    public TimeSpan? ReduceBy { get; set; } // shows fast-clock badge if set

    [Parameter]
    public bool IsTree { get; set; }
    [Parameter]
    public string ImageSize { get; set; } = "64px"; //same for both height and width
    [Parameter]
    public int IconSize { get; set; } = 22;

    private string ImageUrl
    {
        get
        {
            if (IsTree)
            {
                return "/tree.png";
            }
            return $"/{Name}.png";
        }
    }

}