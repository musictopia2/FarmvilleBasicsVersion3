namespace Phase11MVP3.DataAccess.Store;
public class StoreUiStateDocument : IFarmDocument
{
    required public FarmKey Farm { get; set; }
    public EnumCatalogCategory LastCategory { get; set; } = EnumCatalogCategory.Tree;
}