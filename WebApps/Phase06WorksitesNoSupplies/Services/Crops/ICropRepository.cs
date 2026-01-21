namespace Phase06WorksitesNoSupplies.Services.Crops;
public interface ICropRepository
{
    Task<CropSystemState> LoadAsync();
    Task SaveAsync(CropSystemState state);
}