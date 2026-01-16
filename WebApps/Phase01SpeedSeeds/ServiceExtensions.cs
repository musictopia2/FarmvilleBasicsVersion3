using Phase01SpeedSeeds.Components.Custom; //for now.
using Phase01SpeedSeeds.DataAccess.Animals;
using Phase01SpeedSeeds.DataAccess.Balance;
using Phase01SpeedSeeds.DataAccess.Catalog;
using Phase01SpeedSeeds.DataAccess.Core;
using Phase01SpeedSeeds.DataAccess.Crops;
using Phase01SpeedSeeds.DataAccess.Items;
using Phase01SpeedSeeds.DataAccess.Progression;
using Phase01SpeedSeeds.DataAccess.Quests; //not common enough.
using Phase01SpeedSeeds.DataAccess.Store;
using Phase01SpeedSeeds.DataAccess.Trees;
using Phase01SpeedSeeds.DataAccess.Upgrades;
using Phase01SpeedSeeds.DataAccess.Workers;
using Phase01SpeedSeeds.DataAccess.Workshops;
using Phase01SpeedSeeds.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase01SpeedSeeds;

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