namespace Phase11MVP3.Services.Rentals;
public interface IRentalProfile
{
    Task<BasicList<RentalInstanceModel>> LoadAsync();
    Task SaveAsync(BasicList<RentalInstanceModel> rentals);
}