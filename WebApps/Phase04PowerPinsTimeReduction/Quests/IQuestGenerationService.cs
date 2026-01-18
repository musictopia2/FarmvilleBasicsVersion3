namespace Phase04PowerPinsTimeReduction.Quests;

public interface IQuestGenerationService
{

    QuestInstanceModel CreateQuest(int currentLevel,
        BasicList<ItemPlanModel> eligibleItems,
        BasicList<QuestInstanceModel> existingBoard);

}
