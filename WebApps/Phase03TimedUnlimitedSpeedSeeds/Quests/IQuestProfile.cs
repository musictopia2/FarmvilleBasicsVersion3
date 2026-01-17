namespace Phase03TimedUnlimitedSpeedSeeds.Quests;
public interface IQuestProfile
{
    Task<BasicList<QuestInstanceModel>> LoadAsync();
    Task SaveAsync(BasicList<QuestInstanceModel> quests);
}