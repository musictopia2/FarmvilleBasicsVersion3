using Phase09AutoCompleteAll.Components.Custom; //for now.
using Phase09AutoCompleteAll.DataAccess.Animals;
using Phase09AutoCompleteAll.DataAccess.Balance;
using Phase09AutoCompleteAll.DataAccess.Catalog;
using Phase09AutoCompleteAll.DataAccess.Core;
using Phase09AutoCompleteAll.DataAccess.Crops;
using Phase09AutoCompleteAll.DataAccess.InstantUnlimited;
using Phase09AutoCompleteAll.DataAccess.Items;
using Phase09AutoCompleteAll.DataAccess.OutputAugmentation;
using Phase09AutoCompleteAll.DataAccess.Progression;
using Phase09AutoCompleteAll.DataAccess.Quests; //not common enough.
using Phase09AutoCompleteAll.DataAccess.Store;
using Phase09AutoCompleteAll.DataAccess.TimedBoosts;
using Phase09AutoCompleteAll.DataAccess.Trees;
using Phase09AutoCompleteAll.DataAccess.Upgrades;
using Phase09AutoCompleteAll.DataAccess.Workers;
using Phase09AutoCompleteAll.DataAccess.Workshops;
using Phase09AutoCompleteAll.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase09AutoCompleteAll;

public static class ServiceExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection RegisterFarmServices()
        {
            services.AddHostedService<GameTimerService>()
                .AddSingleton<GameRegistry>()
                .AddSingleton<IInventoryRepository, InventoryStockDatabase>()
                .AddSingleton<IStartFarmRegistry, StartFarmDatabase>()
                .AddSingleton<IInventoryFactory, InventoryFactory>()
                .AddSingleton<ITreeFactory, TreeFactory>()
                .AddSingleton<ICropFactory, CropFactory>()
                .AddSingleton<IAnimalFactory, AnimalFactory>()
                .AddSingleton<IWorkshopFactory, WorkshopFactory>()
                .AddSingleton<IWorksiteFactory, WorksiteFactory>()
                .AddSingleton<IWorkerFactory, WorkerFactory>()
                .AddSingleton<IQuestFactory, QuestFactory>()
                .AddSingleton<IUpgradeFactory, UpgradeFactory>()
                .AddSingleton<IProgressionFactory, ProgressionFactory>()
                .AddSingleton<ICatalogFactory, CatalogFactory>()
                .AddSingleton<IStoreFactory, StoreFactory>()
                .AddSingleton<IItemFactory, ItemFactory>()
                .AddSingleton<IInstantUnlimitedFactory, InstantUnlimitedFactory>()
                .AddSingleton<ITimedBoostFactory, TimedBoostFactory>()
                .AddSingleton<IOutputAugmentationFactory, OutputAugmentationFactory>()
                .AddScoped<ReadyStatusService>()
                .AddScoped<OverlayService>()
                .AddScoped<FarmContext>()
                .AddSingleton<IBaseBalanceProvider, BalanceProfileDatabase>() //i think this is safe this time (refer to inventory persistence)
                ;
            return services;
        }
        //not sure about quests.  not until near the end
    }
}