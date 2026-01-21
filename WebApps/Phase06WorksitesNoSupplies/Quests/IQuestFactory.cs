namespace Phase06WorksitesNoSupplies.Quests;
public interface IQuestFactory
{
    QuestServicesContext GetQuestServices(FarmKey farm, CropManager cropManager, TreeManager treeManager);
}