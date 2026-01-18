namespace Phase04PowerPinsTimeReduction.Quests;
public interface IQuestFactory
{
    QuestServicesContext GetQuestServices(FarmKey farm, CropManager cropManager, TreeManager treeManager);
}