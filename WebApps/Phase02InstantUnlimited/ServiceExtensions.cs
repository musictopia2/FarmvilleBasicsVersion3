using Phase02InstantUnlimited.Components.Custom; //for now.
using Phase02InstantUnlimited.DataAccess.Animals;
using Phase02InstantUnlimited.DataAccess.Balance;
using Phase02InstantUnlimited.DataAccess.Catalog;
using Phase02InstantUnlimited.DataAccess.Core;
using Phase02InstantUnlimited.DataAccess.Crops;
using Phase02InstantUnlimited.DataAccess.Items;
using Phase02InstantUnlimited.DataAccess.Progression;
using Phase02InstantUnlimited.DataAccess.Quests; //not common enough.
using Phase02InstantUnlimited.DataAccess.Store;
using Phase02InstantUnlimited.DataAccess.Trees;
using Phase02InstantUnlimited.DataAccess.Upgrades;
using Phase02InstantUnlimited.DataAccess.Workers;
using Phase02InstantUnlimited.DataAccess.Workshops;
using Phase02InstantUnlimited.DataAccess.Worksites;
//these was not common enough to put into global usings.

namespace Phase02InstantUnlimited;

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