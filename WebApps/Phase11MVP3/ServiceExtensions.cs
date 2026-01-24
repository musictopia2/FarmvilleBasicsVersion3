using Phase11MVP3.Components.Custom; //for now.
using Phase11MVP3.DataAccess.Animals;
using Phase11MVP3.DataAccess.Balance;
using Phase11MVP3.DataAccess.Catalog;
using Phase11MVP3.DataAccess.Core;
using Phase11MVP3.DataAccess.Crops;
using Phase11MVP3.DataAccess.InstantUnlimited;
using Phase11MVP3.DataAccess.Items;
using Phase11MVP3.DataAccess.OutputAugmentation;
using Phase11MVP3.DataAccess.Progression;
using Phase11MVP3.DataAccess.Quests; //not common enough.
using Phase11MVP3.DataAccess.Rentals;
using Phase11MVP3.DataAccess.Store;
using Phase11MVP3.DataAccess.TimedBoosts;
using Phase11MVP3.DataAccess.Trees;
using Phase11MVP3.DataAccess.Upgrades;
using Phase11MVP3.DataAccess.Workers;
using Phase11MVP3.DataAccess.Workshops;
using Phase11MVP3.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase11MVP3;

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
                .AddSingleton<IRentalFactory, RentalFactory>()
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