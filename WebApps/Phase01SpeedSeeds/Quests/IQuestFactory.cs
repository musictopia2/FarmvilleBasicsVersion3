namespace Phase01SpeedSeeds.Quests;
public interface IQuestFactory
{
    QuestServicesContext GetQuestServices(FarmKey farm, CropManager cropManager, TreeManager treeManager);
}