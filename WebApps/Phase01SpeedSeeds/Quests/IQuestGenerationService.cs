namespace Phase01SpeedSeeds.Quests;

public interface IQuestGenerationService
{

    QuestInstanceModel CreateQuest(int currentLevel,
        BasicList<ItemPlanModel> eligibleItems,
        BasicList<QuestInstanceModel> existingBoard);

}
