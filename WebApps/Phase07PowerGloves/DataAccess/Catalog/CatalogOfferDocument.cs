namespace Phase07PowerGloves.DataAccess.Catalog;
public class CatalogOfferDocument : IFarmDocument
{
    public required FarmKey Farm { get; init; }
    public required BasicList<CatalogOfferModel> Offers { get; init; } = [];
}