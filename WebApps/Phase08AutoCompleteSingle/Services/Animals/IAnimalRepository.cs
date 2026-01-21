namespace Phase08AutoCompleteSingle.Services.Animals;
public interface IAnimalRepository
{
    Task<BasicList<AnimalAutoResumeModel>> LoadAsync();
    Task SaveAsync(BasicList<AnimalAutoResumeModel> animals);
}