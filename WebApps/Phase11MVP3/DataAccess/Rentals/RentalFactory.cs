namespace Phase11MVP3.DataAccess.Rentals;
public class RentalFactory : IRentalFactory
{
    RentalsServicesContext IRentalFactory.GetRentalServices(FarmKey farm)
    {
        return new()
        {
            RentalProfile = new RentalInstanceDatabase(farm)
        };
    }
}