namespace Phase10Rentals.Services.Rentals;
public interface IRentalFactory
{
    RentalsServicesContext GetRentalServices(FarmKey farm);
}