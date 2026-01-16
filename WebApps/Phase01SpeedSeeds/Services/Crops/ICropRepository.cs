namespace Phase01SpeedSeeds.Services.Crops;
public interface ICropRepository
{
    Task<CropSystemState> LoadAsync();
    Task SaveAsync(CropSystemState state);
}