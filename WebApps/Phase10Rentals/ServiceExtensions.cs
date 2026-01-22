using Phase10Rentals.Components.Custom; //for now.
using Phase10Rentals.DataAccess.Animals;
using Phase10Rentals.DataAccess.Balance;
using Phase10Rentals.DataAccess.Catalog;
using Phase10Rentals.DataAccess.Core;
using Phase10Rentals.DataAccess.Crops;
using Phase10Rentals.DataAccess.InstantUnlimited;
using Phase10Rentals.DataAccess.Items;
using Phase10Rentals.DataAccess.OutputAugmentation;
using Phase10Rentals.DataAccess.Progression;
using Phase10Rentals.DataAccess.Quests; //not common enough.
using Phase10Rentals.DataAccess.Store;
using Phase10Rentals.DataAccess.TimedBoosts;
using Phase10Rentals.DataAccess.Trees;
using Phase10Rentals.DataAccess.Upgrades;
using Phase10Rentals.DataAccess.Workers;
using Phase10Rentals.DataAccess.Workshops;
using Phase10Rentals.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase10Rentals;

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