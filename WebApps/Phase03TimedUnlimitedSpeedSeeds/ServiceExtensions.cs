using Phase03TimedUnlimitedSpeedSeeds.Components.Custom; //for now.
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Animals;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Balance;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Catalog;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Core;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Crops;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.InstantUnlimited;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Items;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Progression;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Quests; //not common enough.
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Store;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.TimedBoosts;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Trees;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Upgrades;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Workers;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Workshops;
using Phase03TimedUnlimitedSpeedSeeds.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase03TimedUnlimitedSpeedSeeds;

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