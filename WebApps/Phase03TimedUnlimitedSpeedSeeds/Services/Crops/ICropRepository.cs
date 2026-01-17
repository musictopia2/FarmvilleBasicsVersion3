namespace Phase03TimedUnlimitedSpeedSeeds.Services.Crops;
public interface ICropRepository
{
    Task<CropSystemState> LoadAsync();
    Task SaveAsync(CropSystemState state);
}