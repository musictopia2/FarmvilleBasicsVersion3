namespace Phase02InstantUnlimited.Quests;

public interface IQuestGenerationService
{

    QuestInstanceModel CreateQuest(int currentLevel,
        BasicList<ItemPlanModel> eligibleItems,
        BasicList<QuestInstanceModel> existingBoard);

}
