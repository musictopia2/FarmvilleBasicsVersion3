namespace Phase08AutoCompleteSingle.Quests;
public interface IQuestFactory
{
    QuestServicesContext GetQuestServices(FarmKey farm, CropManager cropManager, TreeManager treeManager);
}