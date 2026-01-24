
namespace Phase11MVP3.DataAccess.Rentals;
public class RentalInstanceDocument : IFarmDocument
{
    public FarmKey Farm { get; set; }
    public BasicList<RentalInstanceModel> Rentals { get; set; } = [];
}