namespace Phase17Rentals.Models;
public class RentalInstanceDocument : IFarmDocument
{
    public FarmKey Farm { get; set; }
    public BasicList<RentalInstanceModel> Rentals { get; set; } = [];
}