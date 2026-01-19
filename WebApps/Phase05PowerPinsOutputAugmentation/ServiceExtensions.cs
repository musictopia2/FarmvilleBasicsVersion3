using Phase05PowerPinsOutputAugmentation.Components.Custom; //for now.
using Phase05PowerPinsOutputAugmentation.DataAccess.Animals;
using Phase05PowerPinsOutputAugmentation.DataAccess.Balance;
using Phase05PowerPinsOutputAugmentation.DataAccess.Catalog;
using Phase05PowerPinsOutputAugmentation.DataAccess.Core;
using Phase05PowerPinsOutputAugmentation.DataAccess.Crops;
using Phase05PowerPinsOutputAugmentation.DataAccess.InstantUnlimited;
using Phase05PowerPinsOutputAugmentation.DataAccess.Items;
using Phase05PowerPinsOutputAugmentation.DataAccess.Progression;
using Phase05PowerPinsOutputAugmentation.DataAccess.Quests; //not common enough.
using Phase05PowerPinsOutputAugmentation.DataAccess.Store;
using Phase05PowerPinsOutputAugmentation.DataAccess.TimedBoosts;
using Phase05PowerPinsOutputAugmentation.DataAccess.Trees;
using Phase05PowerPinsOutputAugmentation.DataAccess.Upgrades;
using Phase05PowerPinsOutputAugmentation.DataAccess.Workers;
using Phase05PowerPinsOutputAugmentation.DataAccess.Workshops;
using Phase05PowerPinsOutputAugmentation.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase05PowerPinsOutputAugmentation;

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