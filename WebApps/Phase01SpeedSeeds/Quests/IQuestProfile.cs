namespace Phase01SpeedSeeds.Quests;
public interface IQuestProfile
{
    Task<BasicList<QuestInstanceModel>> LoadAsync();
    Task SaveAsync(BasicList<QuestInstanceModel> quests);
}