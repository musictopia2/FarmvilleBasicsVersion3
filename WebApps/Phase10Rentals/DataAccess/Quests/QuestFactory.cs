using Phase10Rentals.RandomQuestGeneratorProcesses; //not common enough.

namespace Phase10Rentals.DataAccess.Quests;
public class QuestFactory : IQuestFactory
{
    QuestServicesContext IQuestFactory.GetQuestServices(FarmKey farm, CropManager cropManager, TreeManager treeManager)
    {
        return new()
        {
            QuestProfile = new QuestProfileDatabase(farm),
            QuestGenerationService = new RandomQuestGenerationService(cropManager, treeManager) //this is somewhat simple but okay for now.  later can do more balancing things.

        };
    }
}