namespace Phase09AutoCompleteAll.Quests;

public interface IQuestGenerationService
{

    QuestInstanceModel CreateQuest(int currentLevel,
        BasicList<ItemPlanModel> eligibleItems,
        BasicList<QuestInstanceModel> existingBoard);

}
