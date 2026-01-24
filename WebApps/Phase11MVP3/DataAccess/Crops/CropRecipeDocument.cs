namespace Phase11MVP3.DataAccess.Crops;
public class CropRecipeDocument
{
    required public string Item { get; init; }
    required public TimeSpan Duration { get; init; }
    required public string Theme { get; init; }
}