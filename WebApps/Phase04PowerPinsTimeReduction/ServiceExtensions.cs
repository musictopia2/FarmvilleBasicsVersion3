using Phase04PowerPinsTimeReduction.Components.Custom; //for now.
using Phase04PowerPinsTimeReduction.DataAccess.Animals;
using Phase04PowerPinsTimeReduction.DataAccess.Balance;
using Phase04PowerPinsTimeReduction.DataAccess.Catalog;
using Phase04PowerPinsTimeReduction.DataAccess.Core;
using Phase04PowerPinsTimeReduction.DataAccess.Crops;
using Phase04PowerPinsTimeReduction.DataAccess.InstantUnlimited;
using Phase04PowerPinsTimeReduction.DataAccess.Items;
using Phase04PowerPinsTimeReduction.DataAccess.Progression;
using Phase04PowerPinsTimeReduction.DataAccess.Quests; //not common enough.
using Phase04PowerPinsTimeReduction.DataAccess.Store;
using Phase04PowerPinsTimeReduction.DataAccess.TimedBoosts;
using Phase04PowerPinsTimeReduction.DataAccess.Trees;
using Phase04PowerPinsTimeReduction.DataAccess.Upgrades;
using Phase04PowerPinsTimeReduction.DataAccess.Workers;
using Phase04PowerPinsTimeReduction.DataAccess.Workshops;
using Phase04PowerPinsTimeReduction.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase04PowerPinsTimeReduction;

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