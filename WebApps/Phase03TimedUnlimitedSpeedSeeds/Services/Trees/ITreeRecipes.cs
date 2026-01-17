namespace Phase03TimedUnlimitedSpeedSeeds.Services.Trees;
public interface ITreeRecipes
{
    Task<BasicList<TreeRecipe>> GetTreesAsync();
}