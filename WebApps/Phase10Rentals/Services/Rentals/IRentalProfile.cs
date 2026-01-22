namespace Phase10Rentals.Services.Rentals;
public interface IRentalProfile
{
    Task<BasicList<RentalInstanceModel>> LoadAsync();
    Task SaveAsync(BasicList<RentalInstanceModel> rentals);
}