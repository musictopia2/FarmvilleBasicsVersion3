namespace Phase17Rentals.Models;
public class CatalogOfferDocument : IFarmDocument
{
    public required FarmKey Farm { get; init; }
    public required BasicList<CatalogOfferModel> Offers { get; init; } = [];
}